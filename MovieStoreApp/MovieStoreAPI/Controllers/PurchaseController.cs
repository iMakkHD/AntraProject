using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Services;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseServiceAsync purchaseServiceAsync;
        public PurchaseController(IPurchaseServiceAsync _purchaseServiceAsync)
        {
            this.purchaseServiceAsync = _purchaseServiceAsync;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await purchaseServiceAsync.GetPurchaseByIdAsync(id));
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await purchaseServiceAsync.GetAllPurchasesAsync());
        }
    }
}
