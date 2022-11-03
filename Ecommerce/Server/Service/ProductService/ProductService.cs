using Ecommerce.Server.Data;
using Ecommerce.Server.Service.ProductService.ProductService;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Server.Service.ProductService
{
    public class ProductsService : IProductsService
    {
        private readonly ProductDbContext _productDbContext;
        public ProductsService(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _productDbContext.Products.Include(p=>p.Variants).ToListAsync()
            };
            return response;
        }
        public async Task<ServiceResponse<Product>> GetProductsByIdAsync(int id)
        {
            var response = new ServiceResponse<Product>();

            var product = await _productDbContext.Products
                .Include(p => p.Variants)
                .ThenInclude(v => v.ProductType)
                .FirstOrDefaultAsync(p => p.Id == id);

            if(product == null)
            {
                response.Success = false;
                response.Msg = "未找到此数据";
            }
            else
            {
                response.Data = product;
            }


            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByURLAsync(string url)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _productDbContext.Products.Where(p=>
                p.Category.Url.ToLower().Equals(url.ToLower()))
                .Include(p=> p.Variants)
                .ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsSearchAsync(string search)
        {

            var products = await _productDbContext.Products.Where(p => p.Title.ToLower().Contains(search.ToLower())
            || p.Description.ToLower().Contains(search.ToLower())).Include(p=> p.Variants).ToListAsync();

            return new ServiceResponse<List<Product>> { 
                Data = products
            };
        }
    }
}
