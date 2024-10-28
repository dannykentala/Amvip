using Amvip.Application.Managers;
using Amvip.Domain.Models.DTOs.Setters;
using Microsoft.AspNetCore.Mvc;

namespace Amvip.Api.Controllers.Suscriptions
{
  [Route("api/suscriptions")]
  [ApiController]
  public class SuscriptionsCreateController: ControllerBase
  {
    private readonly SuscriptionsManager _manager;
    public SuscriptionsCreateController(SuscriptionsManager suscriptionsManager)
    {
      _manager = suscriptionsManager;
    }

    [HttpPost]
    public IActionResult Create(SuscriptionCreateDto suscription)
    {
      return StatusCode(StatusCodes.Status201Created, _manager.Create(suscription));
    }
  }
} 