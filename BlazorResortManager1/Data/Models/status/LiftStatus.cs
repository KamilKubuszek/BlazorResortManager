using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BlazorResortManager1.Data.Models.main;

namespace BlazorResortManager1.Data.Models.status
{
    [Table("liftStatus")]
    public class LiftStatus
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        public bool opened { get; set; } = false;

        [Required]
        public TimeOnly openingTime { get; set; } = TimeOnly.Parse("8:00");

        [Required]
        public TimeOnly closingTime { get; set; } = TimeOnly.Parse("20:00");


        [Required]
        public Guid parentLiftId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Lift? parentLift { get; set; } = null!;

        [Required]
        public Guid statusSheetId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public StatusSheet? statusSheet { get; set; } = null!;
    }

}
