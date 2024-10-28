namespace Amvip.Domain.Models.DTOs.Getters;

public class SuscriptionDto
{
  public string Type { get; set; }
  public DateTime EnrollDate { get; set; }
  public string Status { get; set; }
  
  // From partners
  public string PartnerName { get; set; }

  // From SuscriptionDetails
  public string Title { get; set; }
  public string Description { get; set; }
}