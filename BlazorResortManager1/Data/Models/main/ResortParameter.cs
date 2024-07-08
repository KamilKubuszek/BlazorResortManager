using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorResortManager1.main
{
    [Table("resortParameter")]
    public class ResortParameter
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = "name is required")]
        public string name { get; set; }

        [Required(ErrorMessage = "value is required")]
        public string value { get; set; }

        public Guid resortId { get; set; }
        public Resort resort { get; set; }
    }
}
