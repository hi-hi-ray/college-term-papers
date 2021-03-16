using KeepEverything.RaysaDutra.Domain.Entities;
using System;
using System.Collections.Generic;

namespace KeepEverything.RaysaDutra.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IDisposable
    {
        User GetById(string id);
        IEnumerable<User> GetAll();
        void RemoveLock(string id);
    }
}
