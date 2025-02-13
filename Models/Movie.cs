using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Keeney.Models
{
    public class Movie
    {
        [Key] public int MovieId { get; set; }

        [Required] public string Title { get; set; } 

        [Required] public string Genre { get; set; } 

        [Required] public string Director { get; set; }

        [Required] public int ReleaseYear { get; set; }

        [Required] public string Rating { get; set; } 

        public bool? Edited { get; set; }
        public string? LentTo { get; set; }

        [StringLength(25)] public string? Notes { get; set; }
    }
}