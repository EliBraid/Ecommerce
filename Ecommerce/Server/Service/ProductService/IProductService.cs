namespace Ecommerce.Server.Service.ProductService.ProductService
{
    public interface IProductsService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
    }
}
