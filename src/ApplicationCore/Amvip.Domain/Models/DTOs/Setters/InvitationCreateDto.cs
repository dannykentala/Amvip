namespace Amvip.Domain.Models.DTOs.Setters;

public class InvitationCreateDto
{
  public DateTime CreatedAt { get; set; }
  public DateTime ExpireAt { get; set; }
  public string UserId { get; set; }
  public string PartnerId { get; set; }
}