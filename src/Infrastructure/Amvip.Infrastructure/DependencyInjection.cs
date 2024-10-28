using Amvip.Domain.Interfaces.Repositories;
using Amvip.Infrastructure.Data;
using Amvip.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Amvip.Infrastructure
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
      //----- BaseContext
      services.AddDbContext<JsonBaseContext>();

      //----- Repositories
      services.AddScoped<IPersonalDataRepository, PersonalDataRepository>();
      services.AddScoped<IUsersRepository, UsersRepository>();
      services.AddScoped<IPartnersRepository, PartnersRepository>();
      services.AddScoped<ISuscriptionDetailsRepository, SuscriptionDetailsRepository>();
      services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();
      services.AddScoped<IInvitationsRepository, InvitationsRepository>();

      return services;
    }
  }
}