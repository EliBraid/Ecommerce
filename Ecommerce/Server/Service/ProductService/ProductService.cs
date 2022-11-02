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
                Data = await _productDbContext.Products.ToListAsync()
            };
            return response;
        }
    }
}
