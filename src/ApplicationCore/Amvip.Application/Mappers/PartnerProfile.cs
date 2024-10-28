using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.DTOs.Setters;
using Amvip.Domain.Models.Entities;
using AutoMapper;

namespace Amvip.Application.Mappers;

public class partnerProfile : Profile
{
  public partnerProfile()
  {
    // Source - Destination
    CreateMap<Partner, PartnerDto>();
    CreateMap<PartnerCreateDto, Partner>()
      .ForMember(dest =>
        dest.Id,
        opt => opt.MapFrom(x => Guid.NewGuid().ToString())
      )
      .ForMember(dest =>
        dest.RegisterDate,
        opt => opt.MapFrom(x => DateTime.Now)
      )
      .ForMember(dest =>
        dest.AvailableFunds,
        opt => opt.MapFrom(x => 0)
      );
  }
}