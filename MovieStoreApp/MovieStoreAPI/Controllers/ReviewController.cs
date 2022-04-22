using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Services;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewServiceAsync reviewServiceAsync;
        public ReviewController(IReviewServiceAsync _reviewServiceAsync)
        {
            this.reviewServiceAsync = _reviewServiceAsync;
        }

        [HttpGet]
        //[Route("{id:int}")]
        public async Task<IActionResult> GetByMovie(int movieId)
        {
            return Ok(await reviewServiceAsync.GetReviewByMovieIdAsync(movieId));
        }

        [HttpGet]
        //[Route("{id:int}")]
        public async Task<IActionResult> GetByUser(int userId)
        {
            return Ok(await reviewServiceAsync.GetReviewByUserIdAsync(userId));
        }
    }
}
