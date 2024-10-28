using Amvip.Application.Managers;
using Microsoft.AspNetCore.Mvc;

namespace Amvip.Api.Controllers.SuscriptionDetails
{
  [Route("api/suscriptionDetails")]
  [ApiController]
  public class SuscriptionDetailsController: ControllerBase
  {
    private readonly SuscriptionDetailsManager _manager;
    public SuscriptionDetailsController(SuscriptionDetailsManager suscriptionDetailsManager)
    {
      _manager = suscriptionDetailsManager;
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