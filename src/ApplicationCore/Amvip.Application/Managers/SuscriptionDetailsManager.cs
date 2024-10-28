using Amvip.Application.Generators.Responses;
using Amvip.Application.Responses;
using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.DTOs.Setters;
using Amvip.Domain.Models.Entities;
using AutoMapper;

namespace Amvip.Application.Managers;

public class SuscriptionDetailsManager
{
  private readonly ISuscriptionDetailsRepository _repository;
  private readonly IMapper _mapper;

  public SuscriptionDetailsManager
  (
    ISuscriptionDetailsRepository suscriptionDetailsRepository,
    IMapper mapper
  )
  {
    _repository = suscriptionDetailsRepository;
    _mapper = mapper;
  }

  public Response<IEnumerable<SuscriptionDetailDto>> GetAll()
  {
    IEnumerable<SuscriptionDetail> data = _repository.GetAll().ToList();
    IEnumerable<SuscriptionDetailDto> suscriptionDetail = _mapper.Map<IEnumerable<SuscriptionDetailDto>>(data);

    return BaseResponseGenerator<SuscriptionDetailDto>.GetAll(suscriptionDetail);
  }

  public Response<SuscriptionDetailDto> GetById(string id)
  {
    SuscriptionDetail data = _repository.GetById(id);

    if(data == null)
      return BaseResponseGenerator<SuscriptionDetailDto>.GetById(id);

    SuscriptionDetailDto suscriptionDetail = _mapper.Map<SuscriptionDetailDto>(data);
    return BaseResponseGenerator<SuscriptionDetailDto>.GetById(suscriptionDetail);
  }

  public Response<SuscriptionDetailDto> Create(SuscriptionDetailCreateDto personalData)
  {
    SuscriptionDetail entity = _mapper.Map<SuscriptionDetail>(personalData);

    _repository.Create(entity);
    _repository.Save();

    SuscriptionDetailDto suscriptionDetail = _mapper.Map<SuscriptionDetailDto>(entity);

    return BaseResponseGenerator<SuscriptionDetailDto>.Create(suscriptionDetail);
  }
}