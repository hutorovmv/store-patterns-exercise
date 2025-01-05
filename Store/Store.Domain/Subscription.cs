namespace Store.Domain;

public class SubscriptionProduct : Product
{
  public DateTime StartDate { get; set; }
  public int DurationInMonth { get; set; }
  
  public SubscriptionProduct(string name, decimal price, DateTime startDate, int durationInMonth) : base(name, price)
  {
    StartDate = startDate;
    DurationInMonth = durationInMonth;
  }

  protected SubscriptionProduct(SubscriptionProduct product) : base(product)
  {
    StartDate = product.StartDate;
    DurationInMonth = product.DurationInMonth;
  }

  public override SubscriptionProduct Clone()
  {
    return new SubscriptionProduct(this);
  }
}
