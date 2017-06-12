using KeepEverything.RaysaDutra.Domain.Entities;
using KeepEverything.RaysaDutra.Domain.Interfaces.Repositories;
using KeepEverything.RaysaDutra.Infra.Contexts;
using System;

namespace KeepEverything.RaysaDutra.Infra.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly KeepEverythingEntitiesDB _database;

        public UserRepository(KeepEverythingEntitiesDB database) : base(database)
		{
            _database = database;
        }
        public void Dispose()
        {
            _database.Dispose();
            GC.SuppressFinalize(this);
        }

        public User GetById(string id)
        {
            return _database.Users.Find(id);
        }

        public void RemoveLock(string id)
        {
            _database.Users.Find(id).LockoutEnabled = false;
            _database.SaveChanges();
        }
    }
}
