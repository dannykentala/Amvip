using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Amvip.Domain.Models.Entities;

public class Partner
{
  public string Id { get; set; }
  public double AvailableFunds { get; set; }
  public string RegisterDate { get; set; }
  public string UserId { get; set; }

  [ForeignKey(nameof(UserId))]
  public User? User {get; set;}
  
  [JsonIgnore]
  public List<Suscription>? Suscriptions {get; set;}

  [JsonIgnore]
  public List<Invitation>? Invitations {get; set;}
}