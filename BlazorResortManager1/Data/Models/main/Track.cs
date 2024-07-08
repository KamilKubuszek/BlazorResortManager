using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BlazorResortManager1.status;

namespace BlazorResortManager1.main
{
    [Table("track")]
    public class Track
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = "'name' jest wymagane")]
        [MaxLength(32, ErrorMessage = "'name' może mieć maksymalnie 32 znaki")]
        public string name { get; set; }

        //[Required(ErrorMessage = "'totalHeightMeters' jest wymagane")]
        //public int totalHeightMeters { get; set; }

        //[Required(ErrorMessage = "'inclination' jest wymagane")]
        //public int inclination { get; set; }

        //[Required(ErrorMessage = "'marking' jest wymagane")]
        //[MaxLength(16, ErrorMessage = "'marking' może mieć maksymalnie 16 znaków")]
        //public string marking { get; set; }

        //[Required(ErrorMessage = "'lengthMeters' jest wymagane")]
        //public int lengthMeters { get; set; }

        //[Required(ErrorMessage = "'difficulty' jest wymagane")]
        //public string difficulty { get; set; }
        public ICollection<TrackParameter> parameters { get; set; } = new List<TrackParameter>();
        public ICollection<TrackStatus> statuses { get; set; } = new List<TrackStatus>();
        [ForeignKey("resort")]
        public Guid resortId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Resort? resort { get; set; }
    }


}
