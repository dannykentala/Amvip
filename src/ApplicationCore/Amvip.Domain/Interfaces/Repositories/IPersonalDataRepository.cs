using Amvip.Domain.Models.Entities;

namespace Amvip.Domain.Interfaces.Repositories;

public interface IPersonalDataRepository: IBaseRepository<PersonalData>
{
  PersonalData GetByDocument(string document);
}