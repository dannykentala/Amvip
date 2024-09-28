//Here, we are creating the IGenericRepository interface as a Generic Interface
//Here, we are applying the Generic Constraint 
//The constraint is T which is going to be a class
namespace Amvip.Domain.Interfaces.Repositories;
public interface IBaseRepository<T> where T : class
{
  IEnumerable<T> GetAll();

  // T GetById(object id);
  T GetById(string id);
  void Create(T obj);
  void Update(T obj);
  void Delete(string id);
  void Save();
}