using Amvip.Application.Managers;
using Amvip.Application.Mappers;
using Amvip.Application.Responses;
using Microsoft.Extensions.DependencyInjection;

namespace Amvip.Application
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddApplication (this IServiceCollection services)
    {
      //----- Automapers
      services.AddAutoMapper(typeof(PersonalDataProfile));
      services.AddAutoMapper(typeof(UserProfile));
      services.AddAutoMapper(typeof(partnerProfile));

      //----- Managers
      services.AddScoped<PersonalDataManager>();
      services.AddScoped<UsersManager>();
      services.AddScoped<PartnersManager>();
      services.AddScoped<SuscriptionDetailsManager>();
      services.AddScoped<SuscriptionsManager>();
      services.AddScoped<InvitationsManager>();

      //----- Generators

      return services;
    }
  }
}