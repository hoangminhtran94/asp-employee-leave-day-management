using first_asp_app.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace first_asp_app.Configurations.Entity
{
    internal class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(new Employee
            {
                Id = "admin",
                UserName= "admin@test.com",
                NormalizedUserName= "ADMIN@TEST.COM",
                Email = "admin@test.com",
                NormalizedEmail = "ADMIN@TEST.COM",
                Firstname = "Admin",
                Lastname = "User",
                PasswordHash = hasher.HashPassword(null, "12345678"),
                EmailConfirmed= true
            }, new Employee
            {
                Id = "user",
                Email = "user@test.com",
                UserName= "USER@TEST.COM",
                NormalizedUserName= "USER@TEST.COM",
                NormalizedEmail = "USER@TEST.COM",
                Firstname = "Normal",
                Lastname = "User",
                PasswordHash = hasher.HashPassword(null, "12345678"),
                EmailConfirmed = true
            }
            ); ;
        }
    }
}