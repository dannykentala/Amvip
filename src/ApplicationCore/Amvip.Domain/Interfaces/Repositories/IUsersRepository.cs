using Amvip.Domain.Models.Entities;

namespace Amvip.Domain.Interfaces.Repositories;

public interface IUsersRepository: IBaseRepository<User>
{
  User GetByUserName(string userName);
}