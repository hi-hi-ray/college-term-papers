using KeepEverything.RaysaDutra.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace KeepEverything.RaysaDutra.Infra.Mappings
{
    public class TagMapper : EntityTypeConfiguration<Tag>
    {
        public TagMapper()
        {
            ToTable("Tags");
            HasKey(p => p.IdTag);

            Property(p => p.NameTag).IsRequired().HasMaxLength(255);
        }
    }
}
