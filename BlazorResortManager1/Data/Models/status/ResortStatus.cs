using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BlazorResortManager1.main;

namespace BlazorResortManager1.status
{
    [Table("resortStatus")]
    public class ResortStatus
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = "'opened' jest wymagane")]
        public bool opened { get; set; }

        [Required(ErrorMessage = "'parentresortId' jest wymagany")]
        public Guid parentResortId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Resort? parentResort { get; set; } //= null!;

        [Required(ErrorMessage = "'statusSheetId' jest wymagany")]
        public Guid statusSheetId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public StatusSheet? statusSheet { get; set; } = null!;
    }

}
