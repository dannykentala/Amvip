using Amvip.Application.Managers;
using Microsoft.AspNetCore.Mvc;

namespace Amvip.Api.Controllers.Suscriptions
{
  [Route("api/suscriptions")]
  [ApiController]
  public class SuscriptionsController: ControllerBase
  {
    private readonly SuscriptionsManager _manager;
    public SuscriptionsController(SuscriptionsManager suscriptionsManager)
    {
      _manager = suscriptionsManager;
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