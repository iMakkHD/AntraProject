using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieCastController : ControllerBase
    {
        private readonly IMovieCastServiceAsync movieCastServiceAsync;
        public MovieCastController(IMovieCastServiceAsync _movieCastServiceAsync)
        {
            this.movieCastServiceAsync = _movieCastServiceAsync;
        }
        [HttpGet]
        //[Route("{id:int}")]
        public async Task<IActionResult> GetByUser(int castId)
        {
            return Ok(await movieCastServiceAsync.GetAllByCastIdAsync(castId));
        }
        [HttpGet]
        //[Route("{id:int}")]
        public async Task<IActionResult> GetByMovie(int movieId)
        {
            return Ok(await movieCastServiceAsync.GetAllByMovieIdAsync(movieId));
        }
    }
}
