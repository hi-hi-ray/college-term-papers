using KeepEverything.RaysaDutra.Domain.Entities;
using KeepEverything.RaysaDutra.Domain.Interfaces.Services;
using KeepEverything.RaysaDutra.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace KeepEverything.RaysaDutra.Domain.Services
{
    public class TaskService : ServiceBase<Task>, ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository) : base(taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public IEnumerable<Task> GetByCategory(int id)
        {
            return _taskRepository.GetByCategory(id);
        }

        public void UpdateSituation()
        {
            _taskRepository.UpdateSituation();
        }
    }
}
