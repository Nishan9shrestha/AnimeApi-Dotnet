using Microsoft.EntityFrameworkCore;

namespace AnimeShowApi.Data
{
    public class AnimeDbContext : DbContext
    {
        public AnimeDbContext(DbContextOptions<AnimeDbContext> options) : base(options)
        {
        }

        //these are the entities i want to use 
        public DbSet<Anime> Animes { get; set; }

    }
}
