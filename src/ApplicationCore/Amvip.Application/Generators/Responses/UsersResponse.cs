using Amvip.Application.Responses;
using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.Entities;

namespace Amvip.Application.Generators.Responses;
public static class UsersResponse
{
  public static Response<IEnumerable<UserDto>> GetAll(IEnumerable<UserDto> data)
  {
    return new Response<IEnumerable<UserDto>>("User information", data);
  }

  public static Response<UserDto> GetById(UserDto data)
  {
    return new Response<UserDto>("Success get by id", data);
  }

  public static Response<UserDto> GetById(string id)
  {
    Error error = new Error("Invalid id", $"user with id {id} doesn't exist");
    return new Response<UserDto>("Invalid request", error);
  }

  public static Response<UserDto> Create(UserDto data)
  {
    return new Response<UserDto>("Success created", data);
  }

  public static Response<UserDto> Create(UserDto data, List<Error> errors)
  {
    return new Response<UserDto>("Error when creating", errors);
  }
}