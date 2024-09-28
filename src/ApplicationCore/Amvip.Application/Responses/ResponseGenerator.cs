using Amvip.Domain.Models.DTOs.Getters;

namespace Amvip.Application.Responses;
public static class ResponseGenerator
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

  
  // public string Message {get; set;}
  // public bool Succeded {get; set;}

  // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  // public T? Data {get; set;}

  // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  // public List<Error>? Errors {get; set;}
  // public Response()
  // { }

  // public Response(string message, T data)
  // {
  //   Message = message;
  //   Data = data;
  //   Succeded = true;
  // }

  // public Response(string message, List<Error> errors)
  // {
  //   Message = message;
  //   Errors = errors;
  //   Succeded = false;
  // }

  // public Response(string message, Error error)
  // {
  //   Message = message;
  //   Errors = new List<Error>(){error};
  //   Succeded = false;
  // }
}