﻿using BlazorResortManager1.Data.Models.cameras;
using BlazorResortManager1.Data.Models.main;
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

        [Required]
        public string link { get; set; }

        [Required]
        public Guid resortId { get; set; }
        public Resort resort {  get; set; }
        public ICollection<CameraTrackBinding> trackBindings { get; set; } = new List<CameraTrackBinding>();
        public ICollection<CameraLiftBinding> liftBindings { get; set; } = new List<CameraLiftBinding>();
    }
}
