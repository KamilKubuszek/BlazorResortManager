﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BlazorResortManager1.Data.Models.main;
using BlazorResortManager1.status;

namespace BlazorResortManager1.Data.Models.status
{
    [Table("statusSheet")]
    public class StatusSheet
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = "'dateTime' jest wymagane")]
        //[DataType(DataType.DateTime)]
        public DateTime dateTime { get; set; }

        [Required(ErrorMessage = "'productionVersion' jest wymagane")]
        public bool productionVersion { get; set; }

        [Required(ErrorMessage = "'resortId' jest wymagany")]
        public Guid resortId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Resort? resort { get; set; } = null!;

        public ResortStatus? resortStatus { get; set; } = null!;

        public ICollection<TrackStatus> trackStatuses { get; set; } = new List<TrackStatus>();
        public ICollection<LiftStatus> liftStatuses { get; set; } =  new List<LiftStatus>();
    }

}
