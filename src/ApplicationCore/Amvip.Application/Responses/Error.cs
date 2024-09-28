namespace  Amvip.Application.Responses;
public class Error
{
  public string ErrorName {get; set;}
  public string Message {get; set;}

  public Error()
  { }

  public Error(string errorName, string message)
  {
    ErrorName = errorName;
    Message = message;
  }
}