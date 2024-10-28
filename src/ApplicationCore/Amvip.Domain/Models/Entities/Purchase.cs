namespace Amvip.Domain.Models.Entities;

public class Purchase
{
  public string Id { get; set; }
  public int Quantity { get; set; }
  public string BillId { get; set; }
  public string ProductId { get; set; }
}