using Amvip.Application.Utils;
using Amvip.Domain.Models.Entities;
using Amvip.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Amvip.Infrastructure.Utils;
public class IgnoreProperties
{
  public static List<string> Users
  {
    get
    {
      return 
      [
        nameof(User.PersonalData),
        nameof(User.Partners),
        nameof(User.Invitations)
      ];
    }
  }

  public static List<string> PersonalData
  {
    get
    {
      return 
      [
        nameof(Domain.Models.Entities.PersonalData.Users)
      ];
    }
  }

  public static List<string> Partners
  {
    get
    {
      return 
      [
        nameof(Partner.User),
        nameof(Partner.Suscriptions),
        nameof(Partner.Invitations)
      ];
    }
  }

  public static List<string> Invitations
  {
    get
    {
      return 
      [
        nameof(Invitation.Partner),
        nameof(Invitation.User)
      ];
    }
  }

  public static List<string> Suscriptions
  {
    get
    {
      return 
      [
        nameof(Suscription.Partner),
        nameof(Suscription.SuscriptionDetail)
      ];
    }
  }

  public static List<string> SuscriptionDetails
  {
    get
    {
      return 
      [
        nameof(SuscriptionDetail.Suscriptions)
      ];
    }
  }


  /*
    ## Use case
    When converting to EF Set it list all objects with navigation properties, then you get a reference loop.
    The problem is that you can ignore this loop but the idea is also to don't get the child object into parent.

    So here with serialize this return a string with properties ignore, then we have to convert that string to object again to copy into DB.
  */
  public static object ListAndIgnoreProperties<T>(DbSet<T> set) where T: class
  {
    string entityName = typeof(T).Name;
    IgnorePropertiesJson ignoreProperties = new IgnorePropertiesJson(GetIgnoredProperties(entityName).ToArray());

    string data = JsonConvert.SerializeObject
    (
      set.ToArray(),
      Formatting.Indented,
      new JsonSerializerSettings
      {
        // ContractResolver = new IgnorePropertiesJson(ignoreProperties.ToArray())
        ContractResolver = ignoreProperties
      }
    );

    return JsonConvert.DeserializeObject(data);
  }

  private static List<string> GetIgnoredProperties(string setName)
  {
    List<string> ignoredProperties = new();

    switch (setName)
    {
      case nameof(User):
        ignoredProperties = Users;
        break;
      case nameof(Partner):
        ignoredProperties = Partners;
        break;
      case nameof(Invitation):
        ignoredProperties = Invitations;
        break;
      case nameof(Suscription):
        ignoredProperties = Suscriptions;
        break;
      case nameof(SuscriptionDetail):
        ignoredProperties = SuscriptionDetails;
        break;
      case nameof(PersonalData):
        ignoredProperties = PersonalData;
        break;
    }

    return ignoredProperties;
  }
}