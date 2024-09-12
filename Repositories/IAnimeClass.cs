namespace AnimeShowApi.Repositories
{
    public interface IAnimeClass
    {
        List<Anime> GetAnimeData();
        Anime GetAnimeId(int id);
        List<Anime> CreateARecord(Anime anime);
        Task<List<Anime>> EditARecord(int id, Anime value);
        Task<List<Anime>>  DeleteARecord(int id);
    }
}
