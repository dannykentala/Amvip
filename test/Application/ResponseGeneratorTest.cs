using Amvip.Application.Generators.Responses;
using Amvip.Application.Responses;
using Amvip.Domain.Models.DTOs.Getters;
namespace Amvip.Test.Application;

public class ResponseGeneratorTest
{
  private PersonalDataDto stubPersonalData;
  private List<Error> errors;

  public ResponseGeneratorTest()
  {
    stubPersonalData = new PersonalDataDto()
    {
      DocumentNumber = "102212",
      Name = "Jose Anibal",
      Phone = "3214214053"
    };

    errors = new List<Error>()
    {
      new("bad name", "name not allowed")
    };
  }

  [Fact]
  public void CreateData_SucessfullData_ReturnSucessResponse()
  {
    // arrage
    var stubExpectedResponse = new Response<PersonalDataDto>("Success created", stubPersonalData);

    // act
    var actual = PersonalDataResponse.PersonalDataCreate(stubPersonalData);
    
    // assert
    Assert.Equivalent(stubExpectedResponse, actual);
  }

  [Fact]
  public void CreateData_ErrorData_ReturnErrorResponse()
  {
    // arrage
    var stubExpectedResponse = new Response<PersonalDataDto>("Error when creating", errors);

    // act
    var actual = PersonalDataResponse.PersonalDataCreate(stubPersonalData, errors);
    
    // assert
    Assert.Equivalent(stubExpectedResponse, actual);
  }
}