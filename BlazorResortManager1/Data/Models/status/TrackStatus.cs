﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BlazorResortManager1.main;

namespace BlazorResortManager1.status
{
    [Table("trackStatus")]
    public class TrackStatus
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = "'opened' jest wymagane")]
        public bool opened { get; set; }

        [Required(ErrorMessage = "'snowGroomed' jest wymagane")]
        public bool snowGroomed { get; set; }

        [Required(ErrorMessage = "'illuminated' jest wymagane")]
        public bool illuminated { get; set; }

        [Required(ErrorMessage = "'parentTrackId' jest wymagany")]
        public Guid parentTrackId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Track? parentTrack { get; set; } = null!;

        [Required(ErrorMessage = "'statusSheetId' jest wymagany")]
        public Guid statusSheetId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public StatusSheet? statusSheet { get; set; } = null!;
    }

}
