namespace Amvip.Infrastructure.Data;

public interface IBaseContext
{
  JsonBaseContext DbContext {get; set;}
}