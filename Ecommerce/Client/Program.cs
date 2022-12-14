using Ecommerce.Client;
using Ecommerce.Client.Service.CategoryService;
using Ecommerce.Client.Service.ProductService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Ecommerce.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IProductsService, ProductsService>();
            builder.Services.AddScoped<ICategoryService, CategoriesService>();
            await builder.Build().RunAsync();
        }
    }
}