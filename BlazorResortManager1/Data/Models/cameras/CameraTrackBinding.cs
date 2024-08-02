using BlazorResortManager1.Data.Models.cameras;
using BlazorResortManager1.Data.Models.main;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorResortManager1.Data.Models.camera
{
    [Table("cameraTrackBinding")]
    public class CameraTrackBinding
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        public Guid trackId { get; set; }
        public Track track { get; set; }

        [Required]
        public Guid cameraId { get; set; }
        public Camera camera { get; set; }
    }
}
