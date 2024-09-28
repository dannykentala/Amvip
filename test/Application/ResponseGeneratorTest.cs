// using Amvip.Application.Responses;
// using Amvip.Domain.Models.DTOs.Getters;
// namespace Amvip.Test.Application;

// public class ResponseGeneratorTest
// {
//   [Fact]
//   public void CreateData_SucessfullData_ReturnSucessResponse()
//   {
//     // arrage
//     PersonalDataDto stubPersonalData = new PersonalDataDto()
//     {
//       DocumentNumber = "102212",
//       Name = "Jose Anibal",
//       Phone = "3214214053"
//     };

//     var stubExpectedResponse = new Response<PersonalDataDto>("Success created", stubPersonalData);

//     // act
//     var actual = ResponseGenerator.PersonalDataCreate(stubPersonalData);
    
//     // assert
//     Assert.Equal(stubExpectedResponse, actual);

//   }
// }