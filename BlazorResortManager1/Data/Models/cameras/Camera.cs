using BlazorResortManager1.Data.Models.Lifts;
using BlazorResortManager1.Data.Models.Resorts;
using BlazorResortManager1.Data.Models.Tracks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorResortManager1.Data.Models.cameras
{
    [Table("camera")]
    public class Camera
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        public string name { get; set; }

        public string description { get; set; }

        [Required]
        public string link { get; set; }

        [Required]
        public Guid resortId { get; set; }
        public Resort resort {  get; set; }
        public ICollection<CameraTrackBinding> trackBindings { get; set; } = new List<CameraTrackBinding>();
        public ICollection<CameraLiftBinding> liftBindings { get; set; } = new List<CameraLiftBinding>();
    }
}
