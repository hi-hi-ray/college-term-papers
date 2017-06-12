using KeepEverything.RaysaDutra.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace KeepEverything.RaysaDutra.Infra.Mappings
{
    public class TaskMapper : EntityTypeConfiguration<Task>
    {
        public TaskMapper()
        {
            ToTable("Tasks");

            HasKey(p => p.IdTask);

            Property(p => p.NameTask).IsRequired().HasMaxLength(255);
            Property(p => p.DescriptionTask).IsOptional().HasMaxLength(500);
            Property(p => p.CreatedDateTask).IsRequired();
            Property(p => p.EndedDateTask).IsRequired();
            HasRequired(p => p.Category).WithMany(u => u.Tasks);
            HasMany(p => p.Tags).WithMany(u => u.Tasks);
        }
    }
}
