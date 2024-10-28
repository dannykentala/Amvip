using System.ComponentModel.DataAnnotations.Schema;
using Amvip.Domain.Models.Enums;

namespace Amvip.Domain.Models.Entities;

public class Suscription
{
  public string Id { get; set; }
  public SuscriptionTypeEnum Type { get; set; }
  public DateTime EnrollDate { get; set; }
  public StatusEnum Status { get; set; }
  public string PartnerId { get; set; }
  public string SuscriptionDetailId { get; set; }

  [ForeignKey(nameof(PartnerId))]
  public Partner? Partner {get; set;}

  [ForeignKey(nameof(SuscriptionDetailId))]
  public SuscriptionDetail? SuscriptionDetail {get; set;}
}