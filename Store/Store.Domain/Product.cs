namespace Store.Domain;

using Newtonsoft.Json;

public class Product(string name, decimal price) : IProduct {
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = price;

    protected Product(Product product) : this(product.Name, product.Price) { }
  
    public virtual IProduct Clone()
    {
        return new Product(this);
    }

    public string GetDetails()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
