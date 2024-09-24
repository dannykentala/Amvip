namespace Amvip.Domain.Models.Entities;

public class Purchase
{
  public int Id { get; set; }
  public int Quantity { get; set; }
  public int BillId { get; set; }
  public int ProductId { get; set; }
}