using Ecommerce.Server.Service.CategoryService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategorysService _service; 
        public CategoryController(ICategorysService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategory()
        {
            var result = await _service.GetCategories();

            return Ok(result);

        }
        
    }
}
