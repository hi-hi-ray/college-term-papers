using KeepEverything.RaysaDutra.Domain.Interfaces.Repositories;
using KeepEverything.RaysaDutra.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepEverything.RaysaDutra.Infra.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly KeepEverythingEntitiesDB _database;

        public RepositoryBase(KeepEverythingEntitiesDB database)
        {
            _database = database;
        }

        public void Add(T Entity)
        {
            _database.Set<T>().Add(Entity);
            _database.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _database.Set<T>().ToList();
        }

        public T GetById(int? id)
        {
            return _database.Set<T>().Find(id);
        }

        public void Remove(T Entity)
        {
            _database.Set<T>().Remove(Entity);
            _database.SaveChanges();
        }

        public virtual void Remove(int? id)
        {
            var Entity = GetById(id);
            Remove(Entity);
        }

        public void Update(T Entity)
        {
            _database.Entry(Entity).State = EntityState.Modified;
            _database.SaveChanges();
        }
    }
}
