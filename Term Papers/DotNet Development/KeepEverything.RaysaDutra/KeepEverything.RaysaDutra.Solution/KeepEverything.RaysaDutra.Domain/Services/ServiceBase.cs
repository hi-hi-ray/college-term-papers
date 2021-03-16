using KeepEverything.RaysaDutra.Domain.Interfaces.Repositories;
using KeepEverything.RaysaDutra.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace KeepEverything.RaysaDutra.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repositoryBase;

        public ServiceBase(IRepositoryBase<T> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Add(T Entity)
        {
            _repositoryBase.Add(Entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public T GetById(int? id)
        {
            return _repositoryBase.GetById(id);
        }

        public void Remove(T Entity)
        {
            _repositoryBase.Remove(Entity);
        }

        public void Remove(int? id)
        {
            _repositoryBase.Remove(id);
        }

        public void Update(T Entity)
        {
            _repositoryBase.Update(Entity);
        }
    }
}
