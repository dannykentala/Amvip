using Amvip.Application.Managers;
using Amvip.Application.Mappers;
using Microsoft.Extensions.DependencyInjection;

namespace Amvip.Application
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddApplication (this IServiceCollection services)
    {
      //----- Automapers
      services.AddAutoMapper(typeof(PersonalDataProfile));

      //----- Managers
      services.AddScoped<PersonalDataManager>();

      return services;
    }
  }
}