using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Amvip.Domain.Models.Enums;

namespace Amvip.Domain.Models.Entities;

public class User
{
  public string Id { get; set; }
  public string Username { get; set; }
  public string Password { get; set; }
  public RoleEnum Rol { get; set; }
  public string PersonalDataId { get; set; }

  [ForeignKey(nameof(PersonalDataId))]
  public PersonalData? PersonalData {get; set;}

  [JsonIgnore]
  public List<Partner>? Partners {get; set;}

  [JsonIgnore]
  public List<Invitation>? Invitations {get; set;}
}