using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.DTOs.Setters;
using Amvip.Domain.Models.Entities;
using AutoMapper;

namespace Amvip.Application.Mappers;

public class UserProfile : Profile
{
  public UserProfile()
  {
    // Source - Destination
    CreateMap<User, UserDto>();
    CreateMap<UserCreateDto, User>()
      .ForMember(dest =>
        dest.Id,
        opt => opt.MapFrom(x => Guid.NewGuid().ToString())
      );
  }
}