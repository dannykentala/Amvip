using Amvip.Domain.Models.Enums;

namespace Amvip.Domain.Models.Entities;

public class User
{
  public int Id { get; set; }
  public string Username { get; set; }
  public string Password { get; set; }
  public RoleEnum Rol { get; set; }
  public int PersonalDataId { get; set; }
}