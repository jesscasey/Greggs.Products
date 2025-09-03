using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Greggs.Products.Api;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
        using HttpResponseMessage response = await httpClient.GetAsync("/product");
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });

    public IEnumerable<Product> LatestItems(IEnumerable<Product> products)
    {
        return products.OrderByDescending(p => p.AvailableFrom);
    }
}