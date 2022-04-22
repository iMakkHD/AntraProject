using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Services;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrailerController : ControllerBase
    {
        private readonly ITrailerServiceAsync trailerServiceAsync;
        public TrailerController(ITrailerServiceAsync _trailerServiceAsync)
        {
            this.trailerServiceAsync = _trailerServiceAsync;
        }

        [HttpGet]
        //[Route("{id:int}")]
        public async Task<IActionResult> GetByMovie(int movieId)
        {
            return Ok(await trailerServiceAsync.GetTrailerByMovieIdAsync(movieId));
        }
    }
}
