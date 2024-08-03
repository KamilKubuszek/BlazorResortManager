using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BlazorResortManager1.Data.Models.cameras;
using BlazorResortManager1.Data.Models.main;
using BlazorResortManager1.Data.Models.status;

namespace BlazorResortManager1.Data.Models.main
{
    [Table("lift")]
    public class Lift
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = "'name' jest wymagane")]
        [MaxLength(32, ErrorMessage = "'name' może mieć maksymalnie 32 znaki")]
        public string name { get; set; }

        [Required(ErrorMessage = "'lengthMeters' jest wymagane")]
        public int lengthMeters { get; set; }

        [Required(ErrorMessage = "'estimatedDurationTimeMinutes' jest wymagane")]
        public int estimatedDurationTimeMinutes { get; set; }

        [Required(ErrorMessage = "'type' jest wymagane")]
        [MaxLength(32, ErrorMessage = "'type' może mieć maksymalnie 32 znaki")]
        public string type { get; set; }

        [Required(ErrorMessage = "'peoplePerHour' jest wymagane")]
        public int peoplePerHour { get; set; }

        [Required(ErrorMessage = "'capacityPerSeat' jest wymagane")]
        public int capacityPerSeat { get; set; }

        public ICollection<LiftStatus> statuses { get; set; } = new List<LiftStatus>();

        public ICollection<LiftParameter> parameters { get; set; } = new List<LiftParameter>();
        [ForeignKey("resort")]
        public Guid resortId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Resort? resort { get; set; }

        public ICollection<CameraLiftBinding> cameras { get; set; } = new List<CameraLiftBinding>();
    }
}
