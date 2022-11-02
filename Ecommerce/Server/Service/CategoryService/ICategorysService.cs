namespace Ecommerce.Server.Service.CategoryService
{
    public interface ICategorysService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
    }
}
