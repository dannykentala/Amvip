namespace Amvip.Domain.Models.DTOs.Setters;

public class SuscriptionCreateDto
{
  public string SuscriptionType { get; set; }
  public DateTime SuscriptionDate { get; set; }
  public string Status { get; set; }
  public int PartnerId { get; set; }

  //TODO: We should make a selector in frontend about posible details
  public int SuscriptionDetailId { get; set; }
}