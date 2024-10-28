using Amvip.Application.Generators.Responses;
using Amvip.Application.Responses;
using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.DTOs.Setters;
using Amvip.Domain.Models.Entities;
using Amvip.Domain.Models.Enums;
using AutoMapper;

namespace Amvip.Application.Managers;

public class UsersManager
{
  private readonly IUsersRepository _repository;
  private readonly IMapper _mapper;

  public UsersManager
  (
    IUsersRepository personalDataRepository,
    IMapper mapper
  )
  {
    _repository = personalDataRepository;
    _mapper = mapper;
  }

  public Response<IEnumerable<UserDto>> GetAll()
  {
    IEnumerable<User> data = _repository.GetAll().ToList();
    IEnumerable<UserDto> userDto = _mapper.Map<IEnumerable<UserDto>>(data);

    return UsersResponse.GetAll(userDto);
  }

  public Response<UserDto> GetById(string id)
  {
    User data = _repository.GetById(id);

    if(data == null)
      return UsersResponse.GetById(id);

    UserDto userDto = _mapper.Map<UserDto>(data);
    return UsersResponse.GetById(userDto);
  }

  public Response<UserDto> Create(UserCreateDto personalData)
  {
    User entity = _mapper.Map<User>(personalData);
    // Create normal user
    entity.Rol = RoleEnum.Parthner;

    _repository.Create(entity);
    _repository.Save();

    UserDto userDto = _mapper.Map<UserDto>(entity);

    return UsersResponse.Create(userDto);
  }
}