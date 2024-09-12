namespace AnimeShowApi.Models
{
    public class Anime
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Title { get; set; } = "";
        public string Genre { get; set; } = "";
        public string Description { get; set; } = "";
        public string Author { get; set; } = "";
        public DateOnly ReleasedDate { get; set; }
        public int SeasonsReleased { get; set; }


    }
}
