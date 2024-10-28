using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.DTOs.Setters;
using Amvip.Domain.Models.Entities;
using AutoMapper;

namespace Amvip.Application.Mappers;

public class SuscriptionProfile : Profile
{
  public SuscriptionProfile()
  {
    // Source - Destination
    CreateMap<Suscription, SuscriptionDto>();
      // .ForMember(dest =>
      //   dest.Title,
      //   opt => opt.MapFrom(x => x.SuscriptionDetail.Title)
      // )
      // .ForMember(dest =>
      //   dest.Description,
      //   opt => opt.MapFrom(x => x.SuscriptionDetail.Description)
      // )
      // .ForMember(dest =>
      //   dest.PartnerName,
      //   opt => opt.MapFrom(x => x.Partner.User.PersonalData.Name)
      // );


    CreateMap<SuscriptionCreateDto, Suscription>()
      .ForMember(dest =>
        dest.Id,
        opt => opt.MapFrom(x => Guid.NewGuid().ToString())
      )
      .ForMember(dest =>
        dest.EnrollDate,
        opt => opt.MapFrom(x => DateTime.Now)
      );
  }
}