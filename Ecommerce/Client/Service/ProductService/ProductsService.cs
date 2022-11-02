using Ecommerce.Shared;
using System.Net.Http.Json;

namespace Ecommerce.Client.Service.ProductService
{
    public class ProductsService : IProductsService
    {
        private readonly HttpClient _httpClient;
        public ProductsService(HttpClient httpClient) 
        { 
        _httpClient = httpClient;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public event Action ProductsChanged;

        public async Task GetProducts(string? categoryurl)
        {
            var result = categoryurl == null ?
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Products") :
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/Products/Category/{categoryurl}");
            if(result != null || result.Data != null)
            {
                Products = result.Data;
            }
            ProductsChanged.Invoke();
        }

        public async Task GetProductsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Products");

            Products = response.Data;
        }

        public async Task<ServiceResponse<Product>> GetProductsByIdAsync(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/Products/{id}");
            return result;
        }
    }
}
