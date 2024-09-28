using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.Entities;
using Amvip.Infrastructure.Data;
using AutoMapper;

namespace Amvip.Infrastructure.Repository;

public class PersonalDataRepository: BaseRepository<PersonalData>, IPersonalDataRepository
{
  public PersonalDataRepository(JsonBaseContext context): base(context)
  { }


  public PersonalData GetByDocument(string document)
  {
    var data = table.FirstOrDefault(x => x.DocumentNumber == document);

    return data;
  }
}