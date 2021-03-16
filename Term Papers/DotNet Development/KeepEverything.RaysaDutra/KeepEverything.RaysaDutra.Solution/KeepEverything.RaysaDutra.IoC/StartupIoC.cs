using KeepEverything.RaysaDutra.Domain.Interfaces.Repositories;
using KeepEverything.RaysaDutra.Domain.Interfaces.Services;
using KeepEverything.RaysaDutra.Domain.Services;
using KeepEverything.RaysaDutra.Infra.Contexts;
using KeepEverything.RaysaDutra.Infra.Repositories;
using SimpleInjector;

namespace KeepEverything.RaysaDutra.IoC
{
    public class StartupIoC
    {
        public static void RegisterIoC(Container container)
        {
            // Domain
            container.Register<ICategoryService, CategoryService>(Lifestyle.Scoped);
            container.Register<ITaskService, TaskService>(Lifestyle.Scoped);
            container.Register<ITagService, TagService>(Lifestyle.Scoped);

            // Infra.Data -> Repositories
            container.Register<ICategoryRepository, CategoryRepository>(Lifestyle.Scoped);
            container.Register<ITaskRepository, TaskRepository>(Lifestyle.Scoped);
            container.Register<ITagRepository, TagRepository>(Lifestyle.Scoped);
            container.Register<IUserRepository, UserRepository>(Lifestyle.Scoped);


            container.Register<KeepEverythingEntitiesDB, KeepEverythingEntitiesDB>(Lifestyle.Scoped);
        }

    }
}
