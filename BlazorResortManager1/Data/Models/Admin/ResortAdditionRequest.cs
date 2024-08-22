using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BlazorResortManager1.Data.Models.Admin
{
    [Table("resortAdditionRequest")]
    public class ResortAdditionRequest
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        public string userId { get; set; }
        public virtual ApplicationUser user { get; set; }
        public string coordinatesX { get; set; }
        public string coordinatesY { get; set; }
        public DateOnly date { get; set; } = new DateOnly();
        public bool approved {  get; set; } = false;
    }
}
