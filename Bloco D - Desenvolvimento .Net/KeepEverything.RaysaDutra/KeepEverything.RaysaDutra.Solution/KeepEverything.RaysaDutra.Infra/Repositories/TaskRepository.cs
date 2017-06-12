using System;
using System.Collections.Generic;
using System.Linq;
using KeepEverything.RaysaDutra.Infra.Contexts;
using KeepEverything.RaysaDutra.Domain.Interfaces.Repositories;
using KeepEverything.RaysaDutra.Domain.Entities;
using System.Data.Entity;

namespace KeepEverything.RaysaDutra.Infra.Repositories
{
    public class TaskRepository : RepositoryBase<Task>, ITaskRepository
    {
        private readonly KeepEverythingEntitiesDB _database;

        public TaskRepository(KeepEverythingEntitiesDB database) : base(database)
        {
            _database = database;
        }

        public IEnumerable<Task> GetByCategory(int id)
        {
            var tasks = (from task in _database.Set<Task>()
                         join category in _database.Set<Category>()
                         on task.IdCategory equals id
                         select task).Distinct().ToList();

            return tasks;
        }

        public override void Remove(int? id)
        {
            var entity = GetById(id);
            if (entity.Tags.Any())
                Remove(entity);

        }

        public void UpdateSituation()
        {
            var tarefasAtrasadas = _database.Set<Task>().ToList().Where(
                f => f.CurrentSituationTask == f.Situations[1]
                && DateTime.Compare(f.EndedDateTask, DateTime.Now) <= 0);
            tarefasAtrasadas.ToList().ForEach(f =>
            {
                f.CurrentSituationTask = f.Situations[3];
                _database.Entry(f).State = EntityState.Modified;
            });
            _database.SaveChanges();
        }
    }
}
