using AnimeShowApi.Data;
using AnimeShowApi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AnimeShowApi.Repositories
{
    public class AnimeServiesClass : IAnimeClass

    {
          private readonly AnimeDbContext _dbContext;
        public AnimeServiesClass(AnimeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

     

        public List<Anime> CreateARecord(Anime anime)
        {
            _dbContext.Animes.Add(anime);//the Animes is AnimeDbContext object
            _dbContext.SaveChanges();
            return _dbContext.Animes.ToList();
        }

        public async Task<List<Anime>> DeleteARecord(int id)
        {
            var Aid =await _dbContext.Animes.FindAsync(id);
            if (Aid is null)
                return null;

            _dbContext.Animes.Remove(Aid);
           await _dbContext.SaveChangesAsync();
            return await _dbContext.Animes.ToListAsync();
        }

        public async Task<List<Anime>> EditARecord(int id, Anime value)
        {

            var Aid =await _dbContext.Animes.FindAsync(id);
            if (Aid is null)
                return null;


            Aid.Id = id;
            Aid.Name = value.Name;
            Aid.Description = value.Description;
            Aid.Title = value.Title;
            Aid.Genre = value.Genre;
            Aid.Author = value.Author;
            Aid.ReleasedDate = value.ReleasedDate;
            Aid.SeasonsReleased = value.SeasonsReleased;
            //AnimeList.Add(Aid); dont do this it will again add another same data with the edited data
            await _dbContext.SaveChangesAsync();
            return await _dbContext.Animes.ToListAsync();
        }

        public List<Anime> GetAnimeData()//to get All data
        {
            return _dbContext.Animes.ToList();
        }

        public Anime GetAnimeId(int id)
        {
            var Aid = _dbContext.Animes.Find(id);
            if (Aid is null)
                return null;

            return Aid;
        }
    }
}
