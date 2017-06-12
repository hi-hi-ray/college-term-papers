using System.Collections.Generic;

namespace KeepEverything.RaysaDutra.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int? id);
        void Add(T Entity);
        void Update(T Entity);
        void Remove(T Entity);
        void Remove(int? id);
    }
}
