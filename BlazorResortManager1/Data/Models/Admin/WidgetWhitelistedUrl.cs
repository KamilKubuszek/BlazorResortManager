using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorResortManager1.Data.Models.Admin
{
    [Table("widgetWhitelistedUrl")]
    public class WidgetWhitelistedUrl
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        public string siteUrl { get; set; }
    }
}
