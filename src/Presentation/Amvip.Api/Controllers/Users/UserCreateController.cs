using Amvip.Application.Managers;
using Amvip.Domain.Models.DTOs.Setters;
using Microsoft.AspNetCore.Mvc;

namespace Amvip.Api.Controllers.Users
{
  [Route("api/users")]
  [ApiController]
  public class UsersCreateController: ControllerBase
  {
    private readonly UsersManager _manager;
    public UsersCreateController(UsersManager usersManager)
    {
      _manager = usersManager;
    }

    [HttpPost]
    public IActionResult Create(UserCreateDto user)
    {
      return StatusCode(StatusCodes.Status201Created, _manager.Create(user));
    }
  }
}