using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.Entities;
using Amvip.Infrastructure.Data;

namespace Amvip.Infrastructure.Repository;

public class PersonalDataRepository: BaseRepository<PersonalData>, IPersonalDataRepository
{
  public PersonalDataRepository(JsonBaseContext context): base(context)
  { }

  public PersonalData GetByDocument(string document)
    => table.FirstOrDefault(x => x.DocumentNumber == document);
}