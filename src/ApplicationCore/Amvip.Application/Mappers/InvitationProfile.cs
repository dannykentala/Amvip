using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.DTOs.Setters;
using Amvip.Domain.Models.Entities;
using Amvip.Domain.Models.Enums;
using AutoMapper;

namespace Amvip.Application.Mappers;

public class InvatationProfile : Profile
{
  public InvatationProfile()
  {
    // Source - Destination
    CreateMap<Invitation, InvitationDto>();
    CreateMap<InvitationCreateDto, Invitation>()
      .ForMember(dest =>
        dest.Id,
        opt => opt.MapFrom(x => Guid.NewGuid().ToString())
      )
      .ForMember(dest =>
        dest.Status,
        opt => opt.MapFrom(x => StatusEnum.Active)
      );
  }
}