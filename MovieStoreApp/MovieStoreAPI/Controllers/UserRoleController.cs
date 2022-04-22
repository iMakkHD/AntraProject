using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Services;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleServiceAsync userRoleServiceAsync;
        public UserRoleController(IUserRoleServiceAsync _userRoleServiceAsync)
        {
            this.userRoleServiceAsync = _userRoleServiceAsync;
        }

        [HttpGet]
        //[Route("{id:int}")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await userRoleServiceAsync.GetAllUserRolesAsync());
        }
    }
}
