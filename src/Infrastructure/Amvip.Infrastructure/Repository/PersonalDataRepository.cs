using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.Entities;
using Amvip.Infrastructure.Data;
using AutoMapper;

namespace Amvip.Infrastructure.Repository;

public class PersonalDataRepository: IPersonalDataRepository
{
  private readonly JsonBaseContext _context;
  private readonly IMapper _mapper;

  public PersonalDataRepository(JsonBaseContext context, IMapper mapper)
  {
    _context = context;
    _mapper = mapper;
  }

  // public IEnumerable<PersonalDataDto> GetAll()
  // {
  //     var data = _context.Employees.ToList();
  //     IEnumerable<PersonalDataDto> mapData = _mapper.Map<IEnumerable<PersonalDataDto>>(data);
  //     return mapData;
  // }

  // public PersonalDataDto GetById(int id)
  // {
  //     var data = _context.Employees.Find(id);
  //     PersonalDataDto mapData = _mapper.Map<PersonalDataDto>(data);
  //     return mapData;
  // }

  public PersonalDataDto Create(PersonalDataDto personalData)
  {

    PersonalData entity = _mapper.Map<PersonalData>(personalData);
        
    _context.PersonalData.Add(entity);

    _context.SaveChanges();

    return personalData;
  }

  // public int Delete(int id)
  // {
  //     // Find the entity by ID
  //     var EmployeeEntity = _context.Employees.Find(id);
  //     if (EmployeeEntity == null) return 0;

  //     // Remove entity from the database
  //     _context.Employees.Remove(EmployeeEntity);
  //     return _context.SaveChanges();
  // }
}