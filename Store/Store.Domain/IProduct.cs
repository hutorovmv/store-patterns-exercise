namespace Store.Domain;

public interface IProduct
{
  string Name { get; set; }
  decimal Price { get; set; }

  IProduct Clone();
}
