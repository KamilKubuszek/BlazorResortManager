using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorResortManager1.Data.Models.main
{
    [Table("liftParameter")]
    public class LiftParameter
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = "name is required")]
        public string name { get; set; }

        [Required(ErrorMessage = "value is required")]
        public string value { get; set; }

        public Guid liftId { get; set; }
        public Lift lift { get; set; }
    }
}
