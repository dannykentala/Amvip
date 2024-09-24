using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.Entities;

namespace Amvip.Application.Managers;

public class PersonalDataManager
{
  private readonly IPersonalDataRepository _personalDataRepository;

  public PersonalDataManager
  (
    IPersonalDataRepository personalDataRepository
  )
  {
    _personalDataRepository = personalDataRepository;
  }


  /*
    ## Logic flow

    * Clean: First normalize data
    * Map: Mapping data between models
    * Validate: Validations base in Business Rules
    * AddDefaults: Add default data
    * Repository: Add data to persistence
    * Response: 
  */
  public PersonalDataDto Create(PersonalDataDto personalData)
  {
    PersonalDataDto data = _personalDataRepository.Create(personalData);
    return data;
  }

  // public IEnumerable<PaymentDTO> GetAll()
  // {
  //   return _personalDataRepository.GetAll();
  // }
}