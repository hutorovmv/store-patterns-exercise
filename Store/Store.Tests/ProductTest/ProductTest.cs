using Newtonsoft.Json;
using Store.Domain;

namespace Store.Tests.ProductTest;

public class ProductTest
{
    [Fact]
    public void ProductClone_ShouldCreateProductCopy()
    {
        var product = new Product("Knive", 15m);

        var clone = product.Clone();
        
        Assert.Equal(product.Name, clone.Name);
        Assert.Equal(product.Price, clone.Price);
    }

    [Fact]
    public void PhysicalProductClone_ShouldCreatePhysicalProductCopy()
    {
        var physicalProduct = new Subscription("Knive", 15m, 0.15f);

        var clone = physicalProduct.Clone();

        var physicalProductSerialized = JsonConvert.SerializeObject(physicalProduct);
        var cloneSerialized = JsonConvert.SerializeObject(clone);

        Assert.Equal(physicalProductSerialized, cloneSerialized);
    }

    [Fact]
    public void DigitalProductClone_ShouldCreateDigitalProductCopy()
    {
        var digitalProduct = new DigitalProduct("Knive", 15m, "link");

        var clone = digitalProduct.Clone();

        var physicalProductSerialized = JsonConvert.SerializeObject(digitalProduct);
        var cloneSerialized = JsonConvert.SerializeObject(clone);

        Assert.Equal(physicalProductSerialized, cloneSerialized);
    }

    [Fact]
    public void SubscriptionProductClone_ShouldCreateSubscriptionProductCopy()
    {
        var subscription = new SubscriptionProduct("Knive", 15m, new DateTime(2024, 12, 1), 6);

        var clone = subscription.Clone();

        var subscriptionSerialized = JsonConvert.SerializeObject(subscription);
        var cloneSerialized = JsonConvert.SerializeObject(clone);

        Assert.Equal(subscriptionSerialized, cloneSerialized);
    }
}