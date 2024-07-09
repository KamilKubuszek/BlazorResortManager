using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BlazorResortManager1.Data;
using BlazorResortManager1.Data.Models.main;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlazorResortManager1.user
{
    [Table("permit")]
    public class Permit
    {
        [Key]
        public Guid id { get; set; }

        //[Required]
        //[ForeignKey("ApplicationUser")]
        public Guid userId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        public Guid resortId { get; set; }
        [JsonIgnore]
        public Resort resort { get; set; } = null!;
    }
}
