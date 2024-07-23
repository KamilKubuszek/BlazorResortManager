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

        [Required(ErrorMessage = "'opened' jest wymagane")]
        public bool opened { get; set; }

        [Required(ErrorMessage = "'parentLiftId' jest wymagany")]
        public Guid parentLiftId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Lift? parentLift { get; set; } = null!;

        [Required(ErrorMessage = "'statusSheetId' jest wymagany")]
        public Guid statusSheetId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public StatusSheet? statusSheet { get; set; } = null!;
    }

}
