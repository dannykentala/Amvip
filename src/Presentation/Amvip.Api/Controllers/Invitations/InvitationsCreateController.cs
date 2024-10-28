using Amvip.Application.Managers;
using Amvip.Domain.Models.DTOs.Setters;
using Microsoft.AspNetCore.Mvc;

namespace Amvip.Api.Controllers.Suscriptions
{
  [Route("api/invitations")]
  [ApiController]
  public class InvitationsCreateController: ControllerBase
  {
    private readonly InvitationsManager _manager;
    public InvitationsCreateController(InvitationsManager invitationsManager)
    {
      _manager = invitationsManager;
    }

    [HttpPost]
    public IActionResult Create(InvitationCreateDto invitation)
    {
      return StatusCode(StatusCodes.Status201Created, _manager.Create(invitation));
    }
  }
} 