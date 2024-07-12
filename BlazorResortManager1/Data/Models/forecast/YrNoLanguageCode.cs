using System.ComponentModel.DataAnnotations;

namespace BlazorResortManager1.Data.Models.forecast
{
    public class YrNoLanguageCode
    {
        [Key]
        public Guid id { get; set; }
        public string code { get; set; }
        public ICollection<YrNoCityCode> yrNoCityCodes { get; set; } = new List<YrNoCityCode>();
    }
}
