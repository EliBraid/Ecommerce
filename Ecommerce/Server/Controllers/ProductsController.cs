using Ecommerce.Server.Data;
using Ecommerce.Server.Service.ProductService;
using Ecommerce.Server.Service.ProductService.ProductService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _service;
        public ProductsController(IProductsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult< ServiceResponse<List<Product>>>> GetProduct()
        {
            var result = await _service.GetProductsAsync();

            return Ok(result);
        }
    }
}
