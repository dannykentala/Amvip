using Amvip.Application.Managers;
using Amvip.Domain.Models.DTOs.Getters;
using Microsoft.AspNetCore.Mvc;

namespace Amvip.Api.Controllers.PersonalData
{
  [Route("api/personalData")]
  [ApiController]
  public class PersonalDataController: ControllerBase
  {
    private readonly PersonalDataManager _manager;
    public PersonalDataController(PersonalDataManager manager)
    {
      _manager = manager;
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