using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BlazorResortManager1.Data.Models.cameras;
using BlazorResortManager1.Data.Models.main;

namespace BlazorResortManager1.Data.Models.status
{
    [Table("trackStatus")]
    public class TrackStatus
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = "'opened' jest wymagane")]
        public bool opened { get; set; } = false;

        [Required]
        public TimeOnly openingTime { get; set; } = TimeOnly.Parse("8:00");

        [Required]
        public TimeOnly closingTime { get; set; } = TimeOnly.Parse("20:00");

        [Required]
        public int snowCover {  get; set; }

        [Required]
        public Guid parentTrackId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Track? parentTrack { get; set; } = null!;

        [Required(ErrorMessage = "'statusSheetId' jest wymagany")]
        public Guid statusSheetId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public StatusSheet? statusSheet { get; set; } = null!;     
    }

}
