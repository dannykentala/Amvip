using System.Text.Json.Serialization;

namespace Amvip.Application.Responses;
public class Response<T>
{
  public string Message {get; set;}
  public bool Succeded {get; set;}

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public T? Data {get; set;}

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public List<Error>? Errors {get; set;}
  public Response()
  { }

  public Response(string message, T data)
  {
    Message = message;
    Data = data;
    Succeded = true;
  }

  public Response(string message, List<Error> errors)
  {
    Message = message;
    Errors = errors;
    Succeded = false;
  }

  public Response(string message, Error error)
  {
    Message = message;
    Errors = new List<Error>(){error};
    Succeded = false;
  }
}