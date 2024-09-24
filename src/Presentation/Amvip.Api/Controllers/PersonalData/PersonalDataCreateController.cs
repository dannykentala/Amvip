using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.DTOs.Getters;
using Microsoft.AspNetCore.Mvc;

namespace Amvip.Api.Controllers.PersonalData
{
  [Route("api/personalData")]
  [ApiController]
  public class EmployeesCreateController: ControllerBase
  {
    private readonly IPersonalDataRepository _repository;
    public EmployeesCreateController(IPersonalDataRepository repository)
    {
      _repository = repository;
    }

    [HttpPost]
    public PersonalDataDto Create(PersonalDataDto employee)
    {
      return  _repository.Create(employee);
    }
  }
}