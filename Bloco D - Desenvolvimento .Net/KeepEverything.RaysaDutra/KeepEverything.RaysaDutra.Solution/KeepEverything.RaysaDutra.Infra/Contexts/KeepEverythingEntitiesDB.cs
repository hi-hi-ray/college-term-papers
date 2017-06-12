using KeepEverything.RaysaDutra.Domain.Entities;
using KeepEverything.RaysaDutra.Infra.Mappings;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace KeepEverything.RaysaDutra.Infra.Contexts
{
    public class KeepEverythingEntitiesDB : DbContext
    {
        public KeepEverythingEntitiesDB() : base("KeepEverythingEntitiesDB") { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Conventions
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));


            MappingConfiguration(modelBuilder);
        }

        private void MappingConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMapper());
            modelBuilder.Configurations.Add(new TaskMapper());
            modelBuilder.Configurations.Add(new TagMapper());
            modelBuilder.Configurations.Add(new UserMapper());
        }
    }
}
