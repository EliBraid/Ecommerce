using Ecommerce.Shared;
using System.Net.Http.Json;

namespace Ecommerce.Client.Service.CategoryService
{
    public class CategoriesService : ICategoryService
    {
        private readonly HttpClient _http;
        public CategoriesService(HttpClient http)
        {
            _http= http;
        }
        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task GetCategories()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
            if(response != null || response.Data != null)
            Categories = response.Data;
        }
    }
}
