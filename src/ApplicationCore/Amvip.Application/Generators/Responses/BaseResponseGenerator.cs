using Amvip.Application.Responses;

namespace Amvip.Application.Generators.Responses;
public static class BaseResponseGenerator<T> where T : class
{
  public static string TypeName { get; set; } = NormalEntity();

  private static string NormalEntity()
  {
    string entity = typeof(T).Name;
    return entity.Replace("Dto", "");
  }

  public static Response<IEnumerable<T>> GetAll(IEnumerable<T> data)
  {
    return new Response<IEnumerable<T>>($"{TypeName} information", data);
  }

  public static Response<T> GetById(T data)
  {
    return new Response<T>("Success get by id", data);
  }

  public static Response<T> GetById(string id)
  {
    Error error = new Error("Invalid id", $"{TypeName} with id {id} doesn't exist");
    return new Response<T>("Invalid request", error);
  }

  public static Response<T> Create(T data)
  {
    return new Response<T>("Success created", data);
  }

  public static Response<T> Create(T data, List<Error> errors)
  {
    return new Response<T>("Error when creating", errors);
  }
}