using Amvip.Application.Responses;
using Amvip.Domain.Models.DTOs.Getters;

namespace Amvip.Application.Generators.Responses;
public static class PartnersResponse
{
  public static Response<IEnumerable<PartnerDto>> GetAll(IEnumerable<PartnerDto> data)
  {
    return new Response<IEnumerable<PartnerDto>>("Partner information", data);
  }

  public static Response<PartnerDto> GetById(PartnerDto data)
  {
    return new Response<PartnerDto>("Success get by id", data);
  }

  public static Response<PartnerDto> GetById(string id)
  {
    Error error = new Error("Invalid id", $"Partner with id {id} doesn't exist");
    return new Response<PartnerDto>("Invalid request", error);
  }

  public static Response<PartnerDto> Create(PartnerDto data)
  {
    return new Response<PartnerDto>("Success created", data);
  }

  public static Response<PartnerDto> Create(PartnerDto data, List<Error> errors)
  {
    return new Response<PartnerDto>("Error when creating", errors);
  }
}