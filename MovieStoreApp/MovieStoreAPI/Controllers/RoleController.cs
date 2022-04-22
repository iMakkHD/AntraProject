using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Services;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleServiceAsync roleServiceAsync;
        public RoleController(IRoleServiceAsync _roleServiceAsync)
        {
            this.roleServiceAsync = _roleServiceAsync;
        }

        [HttpGet]
        //[Route("{id:int}")]
        public async Task<IActionResult> GetByName(string name)
        {
            return Ok(await roleServiceAsync.GetRoleByNameAsync(name));
        }
    }
}
