using Amvip.Application.Managers;
using Amvip.Domain.Models.DTOs.Getters;
using Microsoft.AspNetCore.Mvc;

namespace Amvip.Api.Controllers.PersonalData
{
  [Route("api/personalData")]
  [ApiController]
  public class EmployeesCreateController: ControllerBase
  {
    private readonly PersonalDataManager _manager;
    public EmployeesCreateController(PersonalDataManager manager)
    {
      _manager = manager;
    }

    [HttpPost]
    public IActionResult Create(PersonalDataDto employee)
    {
      return StatusCode(StatusCodes.Status201Created, _manager.Create(employee));
    }
  }
}