using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AnimeShowApi.Models;
using AnimeShowApi.Repositories;


namespace AnimeShowApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        private readonly IAnimeClass _animeClass;

        public AnimeController(IAnimeClass animeClass)
        {
           
            _animeClass = animeClass;
        }

        [HttpGet]//to get all the data
        public async Task<ActionResult<List<Anime>>> GetAnimeData()
        {
            return _animeClass.GetAnimeData();
        }

        [HttpGet("{id}")]//to get data using id
        public async Task<ActionResult<List<Anime>>> GetAnimeId(int id)
        {
            var Aid = _animeClass.GetAnimeId(id);
            if (Aid is null)
                return NotFound("No Such Data Exist in the DataBase");

            return Ok(Aid);
        }

        [HttpPost]//this creates new data
        public async Task<ActionResult<List<Anime>>> CreateARecord(Anime anime)
        {
           var result= _animeClass.CreateARecord(anime);
            return Ok(result);
        }

        [HttpPut("{id}")]//this edits the existing datas
        public async Task<ActionResult<List<Anime>>> EditARecord(int id, Anime value)
        {
            var Aid = await _animeClass.EditARecord(id, value);
            if (Aid is null)
                return NotFound("No Such Value Exists");

            return Ok(Aid);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteARecord(int id)
        {
            var Aid =await _animeClass.DeleteARecord(id);
            if (Aid is null)
                return NotFound("No Such Data Exists");

            return Ok("Record deleted successfully");
        }


    }
}
