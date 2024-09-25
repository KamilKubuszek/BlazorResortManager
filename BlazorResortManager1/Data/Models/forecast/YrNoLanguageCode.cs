using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorResortManager1.Data.Models.forecast
{
    //[Table("yrNoLanguageCode")]
    public class YrNoLanguageCode
    {
        [Key]
        public Guid id { get; set; }
        public string code { get; set; }
        public ICollection<YrNoCityCode> yrNoCityCodes { get; set; } = new List<YrNoCityCode>();
    }
}
