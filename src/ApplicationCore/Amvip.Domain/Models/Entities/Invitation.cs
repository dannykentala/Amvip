using Amvip.Domain.Models.Enums;

namespace Amvip.Domain.Models.Entities;

public class Invitation
{
  public int Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime ExpireAt { get; set; }
  public StatusEnum Status { get; set; }
  public int UserId { get; set; }
  public int PartnerId { get; set; }
}