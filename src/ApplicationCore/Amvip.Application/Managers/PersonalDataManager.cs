using Amvip.Application.Responses;
using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.Entities;
using AutoMapper;

namespace Amvip.Application.Managers;

public class PersonalDataManager
{
  private readonly IPersonalDataRepository _personalDataRepository;
  private readonly IMapper _mapper;

  public PersonalDataManager
  (
    IPersonalDataRepository personalDataRepository,
    IMapper mapper
  )
  {
    _personalDataRepository = personalDataRepository;
    _mapper = mapper;
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

  public Response<IEnumerable<PersonalDataDto>> GetAll()
  {
    IEnumerable<PersonalData> data = _personalDataRepository.GetAll().ToList();
    IEnumerable<PersonalDataDto> personalDataDto = _mapper.Map<IEnumerable<PersonalDataDto>>(data);

    return ResponseGenerator.PersonalDataGetAll(personalDataDto);
    // return personalDataDto;
  }

  public Response<PersonalDataDto> GetById(string id)
  {
    PersonalData data = _personalDataRepository.GetById(id);
    PersonalDataDto personalDataDto = _mapper.Map<PersonalDataDto>(data);
    return ResponseGenerator.PersonalDataGetById(personalDataDto);
  }

  public Response<PersonalDataDto> Create(PersonalDataDto personalData)
  {
    PersonalData entity = _mapper.Map<PersonalData>(personalData);
    _personalDataRepository.Create(entity);

    // return personalData;
    return ResponseGenerator.PersonalDataCreate(personalData);
  }
}