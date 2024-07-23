using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BlazorResortManager1.Data.Models.camera;
using BlazorResortManager1.Data.Models.forecast;
using BlazorResortManager1.Data.Models.main;
using BlazorResortManager1.Data.Models.status;

using BlazorResortManager1.user;

namespace BlazorResortManager1.Data.Models.main
{
    [Table("resort")]
    public class Resort
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = "'name' jest wymagane")]
        [MaxLength(64, ErrorMessage = "'name' może mieć maksymalnie 64 znaki")]
        public string name { get; set; }

        [Required(ErrorMessage = "'description' jest wymagane")]
        [MaxLength(128, ErrorMessage = "'description' może mieć maksymalnie 128 znaków")]
        public string description { get; set; }

        [Required(ErrorMessage = "'address' jest wymagane")]
        [MaxLength(128, ErrorMessage = "'address' może mieć maksymalnie 128 znaków")]
        public string address { get; set; }

        [Required(ErrorMessage = "'phoneNumber' jest wymagane")]
        [MaxLength(16, ErrorMessage = "'phoneNumber' może mieć maksymalnie 16 znaków")]
        public string phoneNumber { get; set; }

        [Required(ErrorMessage = "'email' jest wymagane")]
        [MaxLength(64, ErrorMessage = "'email' może mieć maksymalnie 64 znaki")]
        public string email { get; set; }

        [Required(ErrorMessage = "'webpage' jest wymagane")]
        [MaxLength(128, ErrorMessage = "'webpage' może mieć maksymalnie 128 znaków")]
        public string webpage { get; set; }

        public Guid? yrNoCityCodeId { get; set; }
        public YrNoCityCode? yrNoCityCode { get; set; }

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

        public ICollection<CameraResortBinding> cameras { get; set; } = new List<CameraResortBinding>();
    }


}
