using Ecommerce.Shared;

namespace Ecommerce.Client.Service.ProductService
{
    public interface IProductsService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }

        string Message { get; set; }
        Task GetProductsAsync();

        Task<ServiceResponse<Product>> GetProductsByIdAsync(int id);

        Task GetProducts(string? categoryurl);

        Task SearchProducts(string search);

        Task<List<string>> GetProductsSearchSuggestions(string searchText);
    }
}
