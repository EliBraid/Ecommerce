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

        public async Task GetProductsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Products");

            Products = response.Data;
        }
    }
}
