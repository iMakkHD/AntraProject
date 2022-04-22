using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Services;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServiceAsync userServiceAsync;
        public UserController(IUserServiceAsync _userServiceAsync)
        {
            this.userServiceAsync = _userServiceAsync;
        }

        [HttpGet]
        //[Route("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await userServiceAsync.GetByIdAsync(id));
        }
    }
}
