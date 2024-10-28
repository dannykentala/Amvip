using System.Text.Json.Serialization;
using Amvip.Domain.Models.Enums;

namespace Amvip.Domain.Models.DTOs.Setters;
public class SuscriptionCreateDto
{
  [JsonConverter(typeof(JsonStringEnumConverter))]
  public SuscriptionTypeEnum? Type { get; set; }

  [JsonConverter(typeof(JsonStringEnumConverter))]
  public StatusEnum? Status { get; set; }
  public string PartnerId { get; set; }
  public string SuscriptionDetailId { get; set; }
}