using System;
using Xunit;

namespace Greggs.Products.UnitTests;

public class UnitTest1
{
    IEnumerable<Product> testProducts = [new Product
            {
                PriceInPounds = 1m,
                Name = "Sausage Roll",
                AvailableFrom = "2025-01-01"
            },
            new Product
            {
                PriceInPounds = 2m,
                Name = "Veggie Bake",
                AvailableFrom = "2025-01-02"
            },
            new Product
            {
                PriceInPounds = 3m,
                Name = "Steak Bake",
                AvailableFrom = "2025-01-03"
            }
        ].ToArray();

    [Fact]
    public void TestLatestItems()
    {
        var productList = new Program().LatestItems(testProducts);
        Assert(productList.First().AvailableFrom = "2025-01-03");
    }

    [Fact]
    public void TestToEuros()
    {
        var product = new Program().ToEuros(testProducts).First();
        Assert(product.PriceInEuros = 1.11m);
    }
}