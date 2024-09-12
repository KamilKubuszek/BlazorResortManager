namespace BlazorResortManager1.Data.Models.yrnoWeatherForecast
{
    public interface IForecastClient
    {
        /// <summary>
        /// Gets weather
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        /// <returns></returns>
        Task<ForecastModel?> GetWeather(double x, double y);
        double convertToDecimalDegrees(string value);
        IEnumerable<ForecastTableModel> ParseForecastModelToTable(ForecastModel model);
    }
}
