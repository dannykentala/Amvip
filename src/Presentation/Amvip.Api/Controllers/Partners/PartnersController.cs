using Amvip.Application.Managers;
using Microsoft.AspNetCore.Mvc;

namespace Amvip.Api.Controllers.Partners
{
  [Route("api/partners")]
  [ApiController]
  public class PartnersController: ControllerBase
  {
    private readonly PartnersManager _manager;
    public PartnersController(PartnersManager partnersManager)
    {
      _manager = partnersManager;
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