using Amvip.Domain.Models.Entities;

namespace Amvip.Domain.Interfaces.Repositories;

public interface ISubscriptionRepository: IBaseRepository<Suscription>
{
  Suscription GetByPartnerId(string partnerId);
}