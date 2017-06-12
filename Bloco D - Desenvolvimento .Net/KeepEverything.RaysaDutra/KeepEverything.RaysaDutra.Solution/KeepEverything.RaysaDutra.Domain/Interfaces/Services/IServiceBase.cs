using System.Collections.Generic;

namespace KeepEverything.RaysaDutra.Domain.Interfaces.Services
{
    public interface IServiceBase<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int? id);
        void Add(T Entity);
        void Update(T Entity);
        void Remove(T Entity);
        void Remove(int? id);
    }
}
