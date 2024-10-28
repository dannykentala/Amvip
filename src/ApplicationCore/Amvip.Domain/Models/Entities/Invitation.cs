using System.ComponentModel.DataAnnotations.Schema;
using Amvip.Domain.Models.Enums;

namespace Amvip.Domain.Models.Entities;

public class Invitation
{
  public string Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime ExpireAt { get; set; }
  public StatusEnum Status { get; set; }
  public string UserId { get; set; }
  public string PartnerId { get; set; }

  [ForeignKey(nameof(UserId))]
  public User? User {get; set;}

  [ForeignKey(nameof(PartnerId))]
  public Partner? Partner {get; set;}
}