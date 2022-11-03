namespace Ecommerce.Server.Service.ProductService.ProductService
{
    public interface IProductsService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();

        Task<ServiceResponse<Product>> GetProductsByIdAsync(int id);

        Task<ServiceResponse<List<Product>>> GetProductsByURLAsync(string url);

        Task<ServiceResponse<List<Product>>> GetProductsSearchAsync(string search);
    }
}
