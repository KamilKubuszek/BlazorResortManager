using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorResortManager1.Data.Models.camera
{
    [Table("camera")]
    public class Camera
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string link { get; set; }
        public ICollection<CameraTrackBinding> trackBindings { get; set; } = new List<CameraTrackBinding>();
        public ICollection<CameraResortBinding> resortBindings { get; set; } = new List<CameraResortBinding>();
        public ICollection<CameraLiftBinding> liftBindings { get; set; } = new List<CameraLiftBinding>();
    }
}
