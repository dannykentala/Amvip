using Amvip.Application.Managers;
using Microsoft.AspNetCore.Mvc;

namespace Amvip.Api.Controllers.Suscriptions
{
  [Route("api/invitations")]
  [ApiController]
  public class InvitationsController: ControllerBase
  {
    private readonly InvitationsManager _manager;
    public InvitationsController(InvitationsManager invitationsManager)
    {
      _manager = invitationsManager;
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