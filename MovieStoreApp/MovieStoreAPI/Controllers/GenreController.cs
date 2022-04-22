using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Services;
using MovieStoreApp.Core.Models;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreServiceAsync genreServiceAsync;
        public GenreController(IGenreServiceAsync _genreServiceAsync)
        {
            this.genreServiceAsync = _genreServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await genreServiceAsync.GetAllGenreAsync());

        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await genreServiceAsync.GetGenreAsync(id));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Create([FromBody] GenreModel model)
        {
            return Ok(await genreServiceAsync.AddGenreAsync(model));
        }
    }
}
