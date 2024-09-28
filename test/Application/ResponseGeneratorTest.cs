using Amvip.Application.Responses;
using Amvip.Domain.Models.DTOs.Getters;
namespace Amvip.Test.Application;

public class ResponseGeneratorTest
{
  private PersonalDataDto stubPersonalData;
  public ResponseGeneratorTest()
  {
    stubPersonalData = new PersonalDataDto()
    {
      DocumentNumber = "102212",
      Name = "Jose Anibal",
      Phone = "3214214053"
    };
  }

  [Fact]
  public void CreateData_SucessfullData_ReturnSucessResponse()
  {
    // arrage

    var stubExpectedResponse = new Response<PersonalDataDto>("Success created", stubPersonalData);

    // act
    var actual = ResponseGenerator.PersonalDataCreate(stubPersonalData);
    
    // assert
    Assert.Equivalent(stubExpectedResponse, actual);
  }
}