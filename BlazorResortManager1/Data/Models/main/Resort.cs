using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BlazorResortManager1.Data.Models.cameras;
using BlazorResortManager1.Data.Models.forecast;
using BlazorResortManager1.Data.Models.status;

using BlazorResortManager1.user;

namespace BlazorResortManager1.Data.Models.main
{
    [Table("resort")]
    public class Resort
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [MaxLength]
        public string name { get; set; }

        [Required]
        [MaxLength]
        public string description { get; set; }

        [Required]
        [MaxLength]
        public string address { get; set; }

        [Required]
        [MaxLength]
        public string phoneNumber { get; set; }

        [Required]
        [MaxLength]
        [EmailAddress(ErrorMessage = "this field should follow email template")]
        public string email { get; set; }

        [Required]
        [MaxLength]
        public string webpage { get; set; }

        public Guid? yrNoCityCodeId { get; set; }
        public YrNoCityCode? yrNoCityCode { get; set; }
        [Required]
        public bool approved { get; set; }
        [Required]
        public string coordinatesX { get; set; }
        [Required]
        public string coordinatesY { get; set; }

        [JsonIgnore]
        public ICollection<Permit> permits { get; set; } = new List<Permit>();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ICollection<StatusSheet> statusSheets { get; set; } = new List<StatusSheet>();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ICollection<ResortStatus> statuses { get; set; } = new List<ResortStatus>();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ICollection<Track> tracks { get; set; } = new List<Track>();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ICollection<Lift> lifts { get; set; } = new List<Lift>();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ICollection<ResortParameter> resortParameters { get; set; } = new List<ResortParameter>();

        public ICollection<Camera> cameras { get; set; } = new List<Camera>();
    }


}
