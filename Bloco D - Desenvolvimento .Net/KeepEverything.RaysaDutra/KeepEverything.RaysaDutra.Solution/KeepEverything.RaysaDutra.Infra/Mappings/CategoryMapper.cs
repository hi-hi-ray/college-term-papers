using KeepEverything.RaysaDutra.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace KeepEverything.RaysaDutra.Infra.Mappings
{
    public class CategoryMapper : EntityTypeConfiguration<Category>
    {
        public CategoryMapper()
        {
            ToTable("Categories");

            HasKey(p => p.IdCategory);

            Property(p => p.NameCategory).IsRequired().HasMaxLength(255);
            Property(p => p.DescriptionCategory).IsRequired().HasMaxLength(500);

        }
    }
}
