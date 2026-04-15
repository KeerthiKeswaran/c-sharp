using System.Collections.Generic;

namespace Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        void Add(T item);
        T? Get(int id);
        List<T> GetAll();
        void Update(T item);
        void Delete(int id);
        void display(String message);
    }
}