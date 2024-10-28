using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.Entities;
using Amvip.Infrastructure.Data;

namespace Amvip.Infrastructure.Repository;

public class UsersRepository: BaseRepository<User>, IUsersRepository
{
  public UsersRepository(JsonBaseContext context): base(context)
  { }

  public User GetByUserName(string username)
    => table.FirstOrDefault(x => x.Username == username);
}