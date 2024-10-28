using Amvip.Application.Generators.Responses;
using Amvip.Application.Responses;
using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.DTOs.Setters;
using Amvip.Domain.Models.Entities;
using AutoMapper;

namespace Amvip.Application.Managers;

public class InvitationsManager
{
  private readonly IInvitationsRepository _repository;
  private readonly IMapper _mapper;
  public InvitationsManager
  (
    IInvitationsRepository repository,
    IMapper mapper
  )
  {
    _repository = repository;
    _mapper = mapper;
  }

  public Response<IEnumerable<InvitationDto>> GetAll()
  {
    IEnumerable<Invitation> data = _repository.GetAll().ToList();
    IEnumerable<InvitationDto> invitationDetail = _mapper.Map<IEnumerable<InvitationDto>>(data);

    return BaseResponseGenerator<InvitationDto>.GetAll(invitationDetail);
  }

  public Response<InvitationDto> GetById(string id)
  {
    Invitation data = _repository.GetById(id);

    if(data == null)
      return BaseResponseGenerator<InvitationDto>.GetById(id);

    InvitationDto invitationDetail = _mapper.Map<InvitationDto>(data);
    return BaseResponseGenerator<InvitationDto>.GetById(invitationDetail);
  }

  public Response<InvitationDto> Create(InvitationCreateDto personalData)
  {
    Invitation entity = _mapper.Map<Invitation>(personalData);

    _repository.Create(entity);
    _repository.Save();

    InvitationDto invitationDetail = _mapper.Map<InvitationDto>(entity);

    return BaseResponseGenerator<InvitationDto>.Create(invitationDetail);
  }
}