using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.Entities;
using Amvip.Infrastructure.Data;

namespace Amvip.Infrastructure.Repository;

public class SuscriptionDetailsRepository: BaseRepository<SuscriptionDetail>, ISuscriptionDetailsRepository
{
  public SuscriptionDetailsRepository(JsonBaseContext context): base(context)
  { }

  public SuscriptionDetail GetByTitle(string title)
    => table.FirstOrDefault(x => x.Title == title);
}