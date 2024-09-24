using Amvip.Domain.Models.DTOs.Getters;
using Amvip.Domain.Models.Entities;

namespace Amvip.Domain.Interfaces.Repositories;

public interface IPersonalDataRepository
{
  PersonalDataDto Create(PersonalDataDto personalData);   
}