using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.Entities;
using Amvip.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Amvip.Infrastructure.Repository;

public class SubscriptionRepository: BaseRepository<Suscription>, ISubscriptionRepository
{
  public SubscriptionRepository(JsonBaseContext context): base(context)
  { }

  public Suscription GetByPartnerId(string partnerId)
  {
    // return table
    //   .AsNoTracking()
    //   .Include(x => x.Partner)
    //     .ThenInclude(x => x.User)
    //       .ThenInclude(x => x.PersonalData)
    //   .Include(x => x.SuscriptionDetail)
    //   .FirstOrDefault(x => x.PartnerId == partnerId);

    throw new NotImplementedException();
  }
  public IEnumerable<Suscription> GetAll()
  {
    // return table
    //   .AsNoTracking()
    //   .Include(x => x.Partner)
    //     .ThenInclude(x => x.User)
    //       .ThenInclude(x => x.PersonalData)
    //   .Include(x => x.SuscriptionDetail)
    //   .ToList();

    throw new NotImplementedException();
  }
}