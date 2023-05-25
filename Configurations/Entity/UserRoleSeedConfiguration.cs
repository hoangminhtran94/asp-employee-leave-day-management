using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace first_asp_app.Configurations.Entity
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId ="1",
                    UserId="admin"
                }, new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "user"
                }
                );
        }
    }
}