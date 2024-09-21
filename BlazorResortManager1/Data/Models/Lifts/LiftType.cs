using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorResortManager1.Data.Models.Lifts
{
    [Table("liftType")]
    public class LiftType
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string iconUrl { get; set; }


        public ICollection<Lift> lifts { get; set; } = new List<Lift>();
    }
}
