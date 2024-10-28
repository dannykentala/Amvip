using Amvip.Application.Generators.Responses;
using Amvip.Application.Responses;
using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.DTOs.Setters;
using Amvip.Domain.Models.Entities;
using AutoMapper;

namespace Amvip.Application.Managers;

public class PartnersManager
{
  private readonly IPartnersRepository _repository;
  private readonly IMapper _mapper;

  public PartnersManager
  (
    IPartnersRepository personalDataRepository,
    IMapper mapper
  )
  {
    _repository = personalDataRepository;
    _mapper = mapper;
  }

  public Response<IEnumerable<PartnerDto>> GetAll()
  {
    IEnumerable<Partner> data = _repository.GetAll().ToList();
    IEnumerable<PartnerDto> partnerDto = _mapper.Map<IEnumerable<PartnerDto>>(data);

    return PartnersResponse.GetAll(partnerDto);
  }

  public Response<PartnerDto> GetById(string id)
  {
    Partner data = _repository.GetById(id);

    if(data == null)
      return PartnersResponse.GetById(id);

    PartnerDto partnerDto = _mapper.Map<PartnerDto>(data);
    return PartnersResponse.GetById(partnerDto);
  }

  public Response<PartnerDto> Create(PartnerCreateDto personalData)
  {
    Partner entity = _mapper.Map<Partner>(personalData);

    _repository.Create(entity);
    _repository.Save();

    PartnerDto partnerDto = _mapper.Map<PartnerDto>(entity);

    return PartnersResponse.Create(partnerDto);
  }
}