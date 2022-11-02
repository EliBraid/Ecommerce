using Ecommerce.Shared;

namespace Ecommerce.Client.Service.ProductService
{
    public interface IProductsService
    {
        List<Product> Products { get; set; }

        Task GetProductsAsync();
    }
}
