using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.DTOs.Setters;
using Amvip.Domain.Models.Entities;
using AutoMapper;

namespace Amvip.Application.Mappers;

public class SuscriptionDetailProfile : Profile
{
  public SuscriptionDetailProfile()
  {
    // Source - Destination
    CreateMap<SuscriptionDetail, SuscriptionDetailDto>();
    CreateMap<SuscriptionDetailCreateDto, SuscriptionDetail>()
      .ForMember(dest =>
        dest.Id,
        opt => opt.MapFrom(x => Guid.NewGuid().ToString())
      );
  }
}