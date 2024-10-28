using Amvip.Application.Managers;
using Amvip.Domain.Models.DTOs.Setters;
using Microsoft.AspNetCore.Mvc;

namespace Amvip.Api.Controllers.Partners
{
  [Route("api/partners")]
  [ApiController]
  public class PartnersCreateController: ControllerBase
  {
    private readonly PartnersManager _manager;
    public PartnersCreateController(PartnersManager partnersManager)
    {
      _manager = partnersManager;
    }

    [HttpPost]
    public IActionResult Create(PartnerCreateDto partner)
    {
      return StatusCode(StatusCodes.Status201Created, _manager.Create(partner));
    }
  }
}