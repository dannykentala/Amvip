using Amvip.Domain.Models.Enums;

namespace Amvip.Domain.Models.DTOs.Getters;

public class InvitationDto
{
  public string Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime ExpireAt { get; set; }
  public StatusEnum Status { get; set; }
  public string  GuestName{ get; set; }
  public string PartnerName { get; set; }
}