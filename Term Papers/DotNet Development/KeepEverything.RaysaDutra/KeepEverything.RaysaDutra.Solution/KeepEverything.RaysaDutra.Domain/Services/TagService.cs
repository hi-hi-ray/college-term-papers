using KeepEverything.RaysaDutra.Domain.Entities;
using KeepEverything.RaysaDutra.Domain.Interfaces.Repositories;
using KeepEverything.RaysaDutra.Domain.Interfaces.Services;

namespace KeepEverything.RaysaDutra.Domain.Services
{
    public class TagService : ServiceBase<Tag>, ITagService
    {
        public TagService(ITagRepository tagRepository) : base(tagRepository)
        {  }
    }
}
