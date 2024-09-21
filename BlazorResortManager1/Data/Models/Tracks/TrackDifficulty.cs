using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorResortManager1.Data.Models.Tracks
{
    [Table("trackDifficulty")]
    public class TrackDifficulty
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        public ICollection<Track> tracks { get; set; } = new List<Track>();
    }
}
