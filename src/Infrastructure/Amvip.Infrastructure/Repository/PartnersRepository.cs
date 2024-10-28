using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.Entities;
using Amvip.Infrastructure.Data;

namespace Amvip.Infrastructure.Repository;

public class PartnersRepository: BaseRepository<Partner>, IPartnersRepository
{
  public PartnersRepository(JsonBaseContext context): base(context)
  { }
}