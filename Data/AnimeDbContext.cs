using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnimeShowApi.Data
{
    public class AnimeDbContext : IdentityDbContext<IdentityUser>
    {
        public AnimeDbContext(DbContextOptions options) : base(options)
        {
        }

        //these are the entities i want to use 
        public DbSet<Anime> Animes { get; set; }

    }
}
