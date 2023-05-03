using Microsoft.AspNetCore.Mvc;
using SuperZapatos.Application.Interfaces;
using SuperZapatos.Domain.Models;

namespace SuperZapatos.API.Controllers
{
    [Route("services/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        private readonly IStoreApplication _storeApplication;

        public StoresController(IStoreApplication storeApplication)
        {
            _storeApplication = storeApplication;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStores()
        {
            var response = await _storeApplication.GetAllStores();
            return Ok(response);
        }

        [HttpGet("{storeId:int}")]
        public async Task<IActionResult> StoreById(int storeId)
        {
            var response = await _storeApplication.StoreById(storeId);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterStore([FromBody] Store store)
        {
            var response = await _storeApplication.RegisterStore(store);
            return Ok(response);
        }

        [HttpPut("{storeId:int}")]
        public async Task<IActionResult> EditStore(int storeId, [FromBody] Store store)
        {
            var response = await _storeApplication.EditStore(storeId, store);
            return Ok(response);
        }

        [HttpDelete("{storeId:int}")]
        public async Task<IActionResult> DeleteStore(int storeId)
        {
            var response = await _storeApplication.RemoveStore(storeId);
            return Ok(response);
        }
    }
}
