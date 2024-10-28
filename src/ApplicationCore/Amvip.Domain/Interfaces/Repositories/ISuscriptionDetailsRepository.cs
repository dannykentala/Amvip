using Amvip.Domain.Models.Entities;

namespace Amvip.Domain.Interfaces.Repositories;

public interface ISuscriptionDetailsRepository: IBaseRepository<SuscriptionDetail>
{
  SuscriptionDetail GetByTitle(string title);
}