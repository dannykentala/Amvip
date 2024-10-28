using Amvip.Application.Managers;
using Microsoft.AspNetCore.Mvc;

namespace Amvip.Api.Controllers.Users
{
  [Route("api/users")]
  [ApiController]
  public class UsersController: ControllerBase
  {
    private readonly UsersManager _manager;
    public UsersController(UsersManager usersManager)
    {
      _manager = usersManager;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
      return Ok(_manager.GetAll());
    }

    [HttpGet("{Id}")]
    public IActionResult GetById(string id)
    {
      return Ok(_manager.GetById(id));
    }
  }
}