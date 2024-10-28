using Amvip.Application.Managers;
using Amvip.Domain.Models.DTOs.Getters;
using Microsoft.AspNetCore.Mvc;

namespace Amvip.Api.Controllers.PersonalData
{
  [Route("api/personalData")]
  [ApiController]
  public class PersonalDataCreateController: ControllerBase
  {
    private readonly PersonalDataManager _manager;
    public PersonalDataCreateController(PersonalDataManager personalDataManager)
    {
      _manager = personalDataManager;
    }

    [HttpPost]
    public IActionResult Create(PersonalDataDto employee)
    {
      return StatusCode(StatusCodes.Status201Created, _manager.Create(employee));
    }
  }
}