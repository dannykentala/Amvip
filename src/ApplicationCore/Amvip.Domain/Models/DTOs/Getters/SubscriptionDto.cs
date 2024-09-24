namespace Amvip.Domain.Models.DTOs.Getters;

public class SuscriptionDto
{
  public string SuscriptionType { get; set; }
  public DateTime SuscriptionDate { get; set; }
  public string Status { get; set; }
  public string PartnerName { get; set; }

  // From SuscriptionDetails
  public string Title { get; set; }
  public string Description { get; set; }
}