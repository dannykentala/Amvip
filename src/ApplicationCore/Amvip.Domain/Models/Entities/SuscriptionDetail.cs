using System.Text.Json.Serialization;

namespace Amvip.Domain.Models.Entities;

public class SuscriptionDetail
{
  public string Id { get; set; }
  public string Title { get; set; }
  public string Description { get; set; }

  [JsonIgnore]
  public List<Suscription>? Suscriptions {get; set;}
}