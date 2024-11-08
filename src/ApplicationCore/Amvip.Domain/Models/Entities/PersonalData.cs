using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Amvip.Domain.Models.Entities;

public class PersonalData
{
  public string Id { get; set; }
  public string DocumentNumber { get; set; }
  public string Name { get; set; }
  public string Phone { get; set; }

  [JsonIgnore]
  public List<User>? Users {get; set;}
}