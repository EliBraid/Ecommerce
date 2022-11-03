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
            ServiceResponse<List<Product>> response = new ServiceResponse<List<Product>>
            {
                Data = await FindProductSearchAsync(search)
            };
                
            return response;
        }

        private async Task<List<Product>> FindProductSearchAsync(string search)
        {
            return await _productDbContext.Products.Where(p => p.Title.ToLower().Contains(search.ToLower())
            || p.Description.ToLower().Contains(search.ToLower())).Include(p => p.Variants).ToListAsync();
            
        }

        public async Task<ServiceResponse<List<string>>> GetProductsSearchSuggestionAsync(string searchText)
        {
            var products =await FindProductSearchAsync(searchText);
            List<string> result = new List<string>();
            foreach (var product in products)
            {
                if (product.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(product.Title);
                }
                if(product.Description != null)
                {
                    var punctuation = product.Description.Where(char.IsPunctuation)
                        .Distinct().ToArray();
                    var words = product.Description.Split()
                        .Select(s => s.Trim(punctuation));
                    foreach (var word in words)
                    {
                        if(word.Contains(searchText,StringComparison.OrdinalIgnoreCase)
                            && !result.Contains(word))
                        {
                            result.Add(word);
                        }
                    }
                }
            }
            return new ServiceResponse<List<string>> { Data=result };
        }
    }
}
