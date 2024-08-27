namespace BlazorResortManager1.Data.Models.yrnoWeatherForecast
{
    public class Geometry
    {
        public List<double> coordinates { get; set; }
        public string type { get; set; }
    }

    public class Units
    {
        public string air_pressure_at_sea_level { get; set; }
        public string air_temperature { get; set; }
        public string air_temperature_max { get; set; }
        public string air_temperature_min { get; set; }
        public string cloud_area_fraction { get; set; }
        public string cloud_area_fraction_high { get; set; }
        public string cloud_area_fraction_low { get; set; }
        public string cloud_area_fraction_medium { get; set; }
        public string dew_point_temperature { get; set; }
        public string fog_area_fraction { get; set; }
        public string precipitation_amount { get; set; }
        public string precipitation_amount_max { get; set; }
        public string precipitation_amount_min { get; set; }
        public string probability_of_precipitation { get; set; }
        public string probability_of_thunder { get; set; }
        public string relative_humidity { get; set; }
        public string ultraviolet_index_clear_sky_max { get; set; }
        public string wind_from_direction { get; set; }
        public string wind_speed { get; set; }
        public string wind_speed_of_gust { get; set; }
    }

    public class Meta
    {
        public Units units { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class InstantDetails
    {
        public double air_pressure_at_sea_level { get; set; }
        public double air_temperature { get; set; }
        public double cloud_area_fraction { get; set; }
        public double cloud_area_fraction_high { get; set; }
        public double cloud_area_fraction_low { get; set; }
        public double cloud_area_fraction_medium { get; set; }
        public double dew_point_temperature { get; set; }
        public double fog_area_fraction { get; set; }
        public double relative_humidity { get; set; }
        public double wind_from_direction { get; set; }
        public double wind_speed { get; set; }
        public double wind_speed_of_gust { get; set; }
    }

    public class Instant
    {
        public InstantDetails details { get; set; }
    }

    public class NextHoursDetails
    {
        public double air_temperature_max { get; set; }
        public double air_temperature_min { get; set; }
        public double precipitation_amount { get; set; }
        public double precipitation_amount_max { get; set; }
        public double precipitation_amount_min { get; set; }
        public double probability_of_precipitation { get; set; }
        public double probability_of_thunder { get; set; }
        public double ultraviolet_index_clear_sky_max { get; set; }
    }

    public class NextHoursSummary
    {
        public string symbol_code { get; set; }
    }

    public class NextHours
    {
        public NextHoursDetails details { get; set; }
        public NextHoursSummary summary { get; set; }
    }

    public class TimeseriesData
    {
        public Instant instant { get; set; }
        public NextHours next_1_hours { get; set; }
        public NextHours next_6_hours { get; set; }
        public NextHours next_12_hours { get; set; }
    }

    public class Timeseries
    {
        public TimeseriesData data { get; set; }
        public DateTime time { get; set; }
    }

    public class ForecastTableModel
    {
        public DateTime time { get; set; }
        public double maxTemp {  get; set; }
        public double minTemp { get; set; }
        public double precipitation { get; set; }
        public double maxWind { get; set; }
        public double minWind { get; set; }
        public NextHoursSummary midnightToTwelve { get; set; }
        public NextHoursSummary twelveToMidnight { get; set; }
    }

    public class Properties
    {
        public Meta meta { get; set; }
        public List<Timeseries> timeseries { get; set; }
    }

    public class ForecastModel
    {
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
        public string type { get; set; }
    }


}
