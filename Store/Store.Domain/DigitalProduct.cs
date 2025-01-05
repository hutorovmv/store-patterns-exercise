namespace Store.Domain;

public class DigitalProduct : Product
{
  public string DownloadLink { get; set; }
  
  public DigitalProduct(string name, decimal price, string link) : base(name, price)
  {
    DownloadLink = link;
  }

  protected DigitalProduct(DigitalProduct product) : base(product)
  {
    DownloadLink = product.DownloadLink;
  }

  public override DigitalProduct Clone()
  {
    return new DigitalProduct(this);
  }
}
