namespace Store.Domain;

public class Subscription : Product
{
  public float Weight { get; set; }
  
  public Subscription(string name, decimal price, float weight) : base(name, price)
  {
    Weight = weight;
  }

  protected Subscription(Subscription product) : base(product)
  {
    Weight = product.Weight;
  }

  public override Subscription Clone()
  {
    return new Subscription(this);
  }
}
