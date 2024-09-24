using Amvip.Domain.Models.Enums;

namespace Amvip.Domain.Models.Entities;

public class Bill
{
  public int Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime PayOn { get; set; }
  public PaymentStatusEnum Status { get; set; }
  public int UserId { get; set; }
  public int PartnerId { get; set; }
}