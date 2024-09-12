using System.Net.Http;
using System;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Globalization;

namespace BlazorResortManager1.Data.Models.yrnoWeatherForecast
{
    public class ForecastClient : IForecastClient
    {
        #region Limiting

        private static readonly SemaphoreSlim _semaphore = new SemaphoreSlim(10); 
        private static readonly TimeSpan _timeWindow = TimeSpan.FromSeconds(1);
        private static int _requestCount = 0;
        private static DateTime _windowStart = DateTime.UtcNow;

        #endregion

        private IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _config;
        public ForecastClient(IHttpClientFactory httpClientFactory, IConfiguration config)
        {
            _httpClientFactory = httpClientFactory;
            _config = config;
        }

        public async Task<ForecastModel?> GetWeather(double x, double y)
        {

            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            var client = _httpClientFactory.CreateClient("YrnoClient");
            string apiUrl = $"https://api.met.no/weatherapi/locationforecast/2.0/compact?lat={x.ToString(nfi)}&lon={y.ToString(nfi)}";

            await _semaphore.WaitAsync();

            try
            {
                // If we sent 10 requests and the time
                if (_requestCount >= 10)
                {
                    var timeElapsed = DateTime.UtcNow - _windowStart;
                    if (timeElapsed < _timeWindow)
                    {
                        await Task.Delay(_timeWindow - timeElapsed);
                    }

                    _windowStart = DateTime.UtcNow;
                    _requestCount = 0;
                }

                
                var response = await client.GetFromJsonAsync<ForecastModel>(apiUrl);
                //Console.Write(JsonSerializer.Serialize(response, new JsonSerializerOptions { WriteIndented  = true }));
                _requestCount++;
                return response;
                
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public IEnumerable<ForecastTableModel> ParseForecastModelToTable(ForecastModel model)
        {
            //var row = model.properties.timeseries.Where(e =>
            //    e.time.Minute == 0 &&
            //    (e.time.Hour == 0 || e.time.Hour == 12)

            //).Select(e => new Timeseries { data = new TimeseriesData {
            //                        instant =  e.data.instant ,
            //                        next_12_hours = e.data.next_12_hours,
            //                    } }).OrderByDescending(e => e.time);
            IEnumerable<ForecastTableModel> model1 = model.properties.timeseries
            .GroupBy(ts => ts.time.Date)
            .Select(g => new ForecastTableModel
            {
                time = g.Key,
                maxTemp = Math.Round(g.Max(ts => ts.data.instant.details.air_temperature)),
                minTemp = Math.Round(g.Min(ts => ts.data.instant.details.air_temperature)),
                precipitation = Math.Round(g.Sum(ts =>
                    (ts.data.next_1_hours?.details?.precipitation_amount ?? 0) +
                    (ts.data.next_6_hours?.details?.precipitation_amount ?? 0) +
                    (ts.data.next_12_hours?.details?.precipitation_amount ?? 0)
                )),
                maxWind = Math.Round(g.Max(ts => ts.data.instant.details.wind_speed)),
                minWind = Math.Round(g.Min(ts => ts.data.instant.details.wind_speed)),
                midnightToTwelve = g.FirstOrDefault(ts => ts.time.Hour < 12)?.data.next_12_hours?.summary,
                twelveToMidnight = g.FirstOrDefault(ts => ts.time.Hour >= 12)?.data.next_12_hours?.summary
            }).ToArray();
    
            return model1;
        }

        public double convertToDecimalDegrees(string value)
        {
            var match = Regex.Match(value, @"(\d+)°\s*(\d+)'?\s*([NSEW])");

            if (!match.Success)
            {
                throw new ArgumentException("Nieprawidłowy format współrzędnych DMS.");
            }

            // Pobranie stopni, minut i kierunku
            int degrees = int.Parse(match.Groups[1].Value);
            int minutes = int.Parse(match.Groups[2].Value);
            char direction = match.Groups[3].Value[0];

            // Konwersja stopni i minut na wartość dziesiętną
            double decimalDegrees = degrees + (minutes / 60.0);

            // Jeśli kierunek to 'S' lub 'W', wynik będzie ujemny
            if (direction == 'S' || direction == 'W')
            {
                decimalDegrees *= -1;
            }

            return decimalDegrees;
        }
    }
}
