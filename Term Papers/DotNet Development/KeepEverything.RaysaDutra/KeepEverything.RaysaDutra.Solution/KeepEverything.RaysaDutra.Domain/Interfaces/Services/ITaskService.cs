using KeepEverything.RaysaDutra.Domain.Entities;
using System.Collections.Generic;

namespace KeepEverything.RaysaDutra.Domain.Interfaces.Services
{
    public interface ITaskService : IServiceBase<Task>
    {
        IEnumerable<Task> GetByCategory(int id);
        void UpdateSituation();
    }
}
