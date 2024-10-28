using Amvip.Domain.Models.Enums;

namespace Amvip.Domain.Models.Entities;

public class VipRequest
{
  public string Id { get; set; }
  public string PartnerId { get; set; }
  public DateTime Date { get; set; }
}