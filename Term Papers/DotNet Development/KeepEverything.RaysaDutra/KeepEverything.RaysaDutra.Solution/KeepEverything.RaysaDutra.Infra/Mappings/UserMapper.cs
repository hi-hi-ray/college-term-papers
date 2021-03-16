using KeepEverything.RaysaDutra.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace KeepEverything.RaysaDutra.Infra.Mappings
{
    public class UserMapper : EntityTypeConfiguration<User>
    {
        public UserMapper()
        {
            ToTable("Users");

            HasKey(u => u.Id);

            Property(u => u.Id).IsRequired().HasMaxLength(100);
            Property(u => u.Email).IsRequired().HasMaxLength(255);
            Property(u => u.UserName).IsRequired().HasMaxLength(255);
            Property(u => u.PhoneNumber).IsRequired().HasMaxLength(50);
            Property(u => u.LockoutEnabled).IsRequired();

        }
    }
}
