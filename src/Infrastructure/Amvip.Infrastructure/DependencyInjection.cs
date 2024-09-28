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
      services.AddDbContext<IBaseContext, JsonBaseContext>();

      //----- Repositories
      services.AddScoped<IPersonalDataRepository, PersonalDataRepository>();

      return services;
    }
  }
}