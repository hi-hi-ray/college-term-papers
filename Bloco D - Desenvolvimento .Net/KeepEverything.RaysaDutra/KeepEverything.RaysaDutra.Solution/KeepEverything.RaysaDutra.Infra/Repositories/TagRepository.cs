using KeepEverything.RaysaDutra.Domain.Entities;
using KeepEverything.RaysaDutra.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeepEverything.RaysaDutra.Infra.Contexts;

namespace KeepEverything.RaysaDutra.Infra.Repositories
{
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(KeepEverythingEntitiesDB database) : base(database)
        {  }
    }
}
