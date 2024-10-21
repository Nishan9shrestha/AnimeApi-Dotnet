using System.ComponentModel.DataAnnotations;

namespace AnimeShowApi.Models
{
    public class Anime
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";
        public string Title { get; set; } = "";
        public string Genre { get; set; } = "";
        public string Description { get; set; } = "";

        [Required]
        public string Author { get; set; } = "";
        public DateOnly ReleasedDate { get; set; }
        public int SeasonsReleased { get; set; }


    }
}
