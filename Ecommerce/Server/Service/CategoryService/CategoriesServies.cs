using Ecommerce.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Server.Service.CategoryService
{
    public class CategoriesServies : ICategorysService
    {
        private readonly ProductDbContext _context; 
        public CategoriesServies(ProductDbContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var response = new ServiceResponse<List<Category>>();
            var category = await _context.Categorys.ToListAsync();
            response.Data = category;
            
            return response;
        }

        
    }
}
