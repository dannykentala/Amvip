using Amvip.Domain.Models.Enums;

namespace Amvip.Domain.Models.Entities;

public class Suscription
{
  public int Id { get; set; }
  public SuscriptionTypeEnum SuscriptionType { get; set; }
  public DateTime SuscriptionDate { get; set; }
  public StatusEnum Status { get; set; }
  public int PartnerId { get; set; }
  public int SuscriptionDetailId { get; set; }
}