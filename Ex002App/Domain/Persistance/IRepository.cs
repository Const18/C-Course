using Model;

namespace Persistance;

public interface IRepository<T>
{
  void Append(T contact);
  T[] GetAll();
  T Get(int id);
  void Update(int id, T contact);
  void Remove(int id);
}