using KeepEverything.RaysaDutra.Domain.Entities;
using System.Collections.Generic;

namespace KeepEverything.RaysaDutra.Domain.Interfaces.Repositories
{
    public interface ITaskRepository : IRepositoryBase<Task>
    {
        IEnumerable<Task> GetByCategory(int id);
        void UpdateSituation();
    }
}
