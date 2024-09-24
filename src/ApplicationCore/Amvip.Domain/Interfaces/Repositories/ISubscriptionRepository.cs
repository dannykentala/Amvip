using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.DTOs.Setters;

namespace Amvip.Domain.Interfaces.Repositories;

public interface ISubscriptionRepository
{
  SuscriptionDto Add(SuscriptionCreateDto suscription);   
}