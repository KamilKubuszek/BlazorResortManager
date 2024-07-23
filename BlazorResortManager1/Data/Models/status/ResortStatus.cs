using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BlazorResortManager1.Data.Models.main;

namespace BlazorResortManager1.Data.Models.status
{
    [Table("resortStatus")]
    public class ResortStatus
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        public bool opened { get; set; }

        [Required]
        public TimeOnly openingTime { get; set; }

        [Required]
        public TimeOnly closingTime { get; set; }

        [Required]
        public Guid parentResortId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Resort? parentResort { get; set; } //= null!;

        [Required]
        public Guid statusSheetId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public StatusSheet? statusSheet { get; set; } = null!;
    }

}
