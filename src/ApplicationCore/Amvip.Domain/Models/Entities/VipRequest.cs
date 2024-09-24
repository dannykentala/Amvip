using Amvip.Domain.Models.Enums;

namespace Amvip.Domain.Models.Entities;

public class VipRequest
{
  public int Id { get; set; }
  public int PartnerId { get; set; }
  public DateTime Date { get; set; }
}