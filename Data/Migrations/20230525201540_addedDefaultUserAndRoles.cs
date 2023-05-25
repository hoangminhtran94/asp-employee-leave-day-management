using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace first_asp_app.Data.Migrations
{
    public partial class addedDefaultUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "d526a0ae-ae00-41a7-91ef-be789be25d11", "Administrator", "ADMINISTRATOR" },
                    { "2", "ec8975cf-1951-481a-a115-b5db3b823a0b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "admin", 0, "d5461f7d-d51a-4ccf-932e-91a26c597608", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "Admin", "User", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEPzm2nnvjyX0cmTnbNGmR/IOIs25xwEkDIPYe+QtY5Cqv+g1D9A32gqqWPjwAeGdbw==", null, false, "981ef174-b118-46c7-9143-fce289ac4795", null, false, null },
                    { "user", 0, "7ae1a876-01c4-43e4-9026-88ef0206f5d0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@test.com", false, "Normal", "User", false, null, "USER@TEST.COM", null, "AQAAAAEAACcQAAAAEOZKE2tnhrfyI7xuRVyD2esTHIyBxfnl+6KpiC+hIn0kTK4/tXUFRYmavn4YVc4ICg==", null, false, "31ca3984-a627-4cc1-89b4-1c8a2e78002e", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "admin" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "user" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user");
        }
    }
}
