using Amvip.Domain.Models.Enums;

namespace Amvip.Domain.Models.Entities;

public class Bill
{
  public string Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime PayOn { get; set; }
  public PaymentStatusEnum Status { get; set; }
  public string UserId { get; set; }
  public string PartnerId { get; set; }
}