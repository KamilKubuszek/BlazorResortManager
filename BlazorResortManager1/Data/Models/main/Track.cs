using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BlazorResortManager1.Data.Models.cameras;
using BlazorResortManager1.Data.Models.status;

namespace BlazorResortManager1.Data.Models.main
{
    [Table("track")]
    public class Track
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [MaxLength(32, ErrorMessage = "'name' może mieć maksymalnie 32 znaki")]
        [MinLength(3)]
        public string name { get; set; }

        [Required]
        public int totalHeightMeters { get; set; }

        [Required]
        public int inclination { get; set; }

        [Required]
        public bool illuminated { get; set; }

        [Required]
        public bool snowGroomed {  get; set; }

        [Required]
        [MaxLength(16, ErrorMessage = "'marking' może mieć maksymalnie 16 znaków")]
        public string marking { get; set; }

        [Required]
        public int lengthMeters { get; set; }

        [Required]
        public string difficulty { get; set; }
        public ICollection<TrackParameter> parameters { get; set; } = new List<TrackParameter>();
        public ICollection<TrackStatus> statuses { get; set; } = new List<TrackStatus>();
        [ForeignKey("resort")]
        public Guid resortId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Resort? resort { get; set; }

        public ICollection<CameraTrackBinding> cameras { get; set; } = new List<CameraTrackBinding>();
    }


}
