using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Services;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieGenreController : ControllerBase
    {
        private readonly IMovieGenreServiceAsync movieGenreServiceAsync;
        public MovieGenreController(IMovieGenreServiceAsync _movieGenreServiceAsync)
        {
            this.movieGenreServiceAsync = _movieGenreServiceAsync;
        }

        [HttpGet]
        //[Route("{id:int}")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await movieGenreServiceAsync.GetAllGenresAsync());
        }
    }
}
