using Amvip.Application.Managers;
using Amvip.Domain.Models.DTOs.Setters;
using Microsoft.AspNetCore.Mvc;

namespace Amvip.Api.Controllers.SuscriptionDetails
{
  [Route("api/suscriptionDetails")]
  [ApiController]
  public class SuscriptionDetailsCreateController: ControllerBase
  {
    private readonly SuscriptionDetailsManager _manager;
    public SuscriptionDetailsCreateController(SuscriptionDetailsManager suscriptionDetailsManager)
    {
      _manager = suscriptionDetailsManager;
    }

    [HttpPost]
    public IActionResult Create(SuscriptionDetailCreateDto suscriptionDetail)
    {
      return StatusCode(StatusCodes.Status201Created, _manager.Create(suscriptionDetail));
    }
  }
}