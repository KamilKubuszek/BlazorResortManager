﻿using BlazorResortManager1.Data.Models.cameras;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorResortManager1.Data.Models.Lifts
{
    [Table("cameraLiftBinding")]
    public class CameraLiftBinding
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        public Guid liftId { get; set; }
        public Lift lift { get; set; }

        [Required]
        public Guid cameraId { get; set; }
        public Camera camera { get; set; }
    }
}
