using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using XuanLuxShopWeb;

namespace XuanLuxShopWeb
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //ª`¤J
            builder.Services.AddSingleton<Repository.IProduct, Repository.Implement.ProductRepository>();

            //µù¥UAntDesign
            builder.Services.AddAntDesign();

            await builder.Build().RunAsync();
        }
    }
}