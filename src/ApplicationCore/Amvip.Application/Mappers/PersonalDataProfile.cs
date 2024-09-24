using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.Entities;
using AutoMapper;

namespace Amvip.Application.Mappers;

public class PersonalDataProfile : Profile
{
    public PersonalDataProfile()
    {
        // Source - Destination
        CreateMap<PersonalData, PersonalDataDto>();
        CreateMap<PersonalDataDto, PersonalData>()
            .ForMember(dest =>
                dest.Id,
                opt => opt.MapFrom(x => Guid.NewGuid().ToString())
            );
    }
}