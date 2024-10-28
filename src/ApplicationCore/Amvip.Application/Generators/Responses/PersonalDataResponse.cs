using Amvip.Application.Responses;
using Amvip.Domain.Models.DTOs.Getters;

namespace Amvip.Application.Generators.Responses;
public static class PersonalDataResponse
{
  public static Response<IEnumerable<PersonalDataDto>> PersonalDataGetAll(IEnumerable<PersonalDataDto> data)
  {
    return new Response<IEnumerable<PersonalDataDto>>("Personal data information", data);
  }

  public static Response<PersonalDataDto> PersonalDataGetById(PersonalDataDto data)
  {
    return new Response<PersonalDataDto>("Success get by id", data);
  }

  public static Response<PersonalDataDto> PersonalDataCreate(PersonalDataDto data)
  {
    return new Response<PersonalDataDto>("Success created", data);
  }

  public static Response<PersonalDataDto> PersonalDataCreate(PersonalDataDto data, List<Error> errors)
  {
    return new Response<PersonalDataDto>("Error when creating", errors);
  }
}