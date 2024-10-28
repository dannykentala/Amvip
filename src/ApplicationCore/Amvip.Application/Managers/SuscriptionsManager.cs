using Amvip.Application.Generators.Responses;
using Amvip.Application.Responses;
using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.DTOs.Setters;
using Amvip.Domain.Models.Entities;
using AutoMapper;

namespace Amvip.Application.Managers;

public class SuscriptionsManager
{
  private readonly ISubscriptionRepository _repository;
  private readonly IMapper _mapper;
  public SuscriptionsManager
  (
    ISubscriptionRepository suscriptionDetailsRepository,
    IMapper mapper
  )
  {
    _repository = suscriptionDetailsRepository;
    _mapper = mapper;
  }

  public Response<IEnumerable<SuscriptionDto>> GetAll()
  {
    IEnumerable<Suscription> data = _repository.GetAll().ToList();
    IEnumerable<SuscriptionDto> suscriptionDetail = _mapper.Map<IEnumerable<SuscriptionDto>>(data);

    return BaseResponseGenerator<SuscriptionDto>.GetAll(suscriptionDetail);
  }

  public Response<SuscriptionDto> GetById(string id)
  {
    Suscription data = _repository.GetById(id);

    if(data == null)
      return BaseResponseGenerator<SuscriptionDto>.GetById(id);

    SuscriptionDto suscriptionDetail = _mapper.Map<SuscriptionDto>(data);
    return BaseResponseGenerator<SuscriptionDto>.GetById(suscriptionDetail);
  }

  public Response<SuscriptionDto> Create(SuscriptionCreateDto personalData)
  {
    Suscription entity = _mapper.Map<Suscription>(personalData);

    _repository.Create(entity);
    _repository.Save();

    SuscriptionDto suscriptionDetail = _mapper.Map<SuscriptionDto>(entity);

    return BaseResponseGenerator<SuscriptionDto>.Create(suscriptionDetail);
  }
}