using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Services;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {
        private readonly IFavoriteServiceAsync favoriteServiceAsync;
        public FavoriteController(IFavoriteServiceAsync _favoriteServiceAsync)
        {
            this.favoriteServiceAsync = _favoriteServiceAsync;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> Get()
        {
            return Ok(await favoriteServiceAsync.GetAllFavoritesAsync());
        }
    }
}
