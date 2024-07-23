using BlazorResortManager1.Data.Models.main;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorResortManager1.Data.Models.camera
{
    [Table("cameraResortBinding")]
    public class CameraResortBinding
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        public Guid resortId { get; set; }
        public Resort resort { get; set; }

        [Required]
        public Guid cameraId { get; set; }
        public Camera camera { get; set; }
    }
}
