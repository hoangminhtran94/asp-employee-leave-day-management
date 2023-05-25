using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace first_asp_app.Data.Migrations
{
    public partial class UpdatedDefaultUserAndRoles1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6ea30fad-6c30-4d7a-b398-4f313fab7e3e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6b194c81-ac65-4dad-b830-988b003bbf67");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cd8e6ba-7bd3-43bb-86db-61f53ddf4ef8", true, "AQAAAAEAACcQAAAAELKlX7ftNDDcEWQ3MDBE4Jc6zmy4tO+9MChRpMFwg3D9kRWvjrTNXKw4fQK4qBq/Hg==", "d835bb09-ff9e-40c7-84f2-b8c0ebb5d3ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce5d3e0e-3608-45f6-81cc-cf1e1eaac16b", true, "AQAAAAEAACcQAAAAEAoqnAPr9k0kl6zg9Mr30LzMPm4fCL0d2f9UKOPi3aX++1VnfJn/gw0jLxYDSMQj+w==", "21821510-39eb-420d-904a-43431b2c328d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2e118dbf-9779-4fe0-af3c-a2ce92687482");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f3974f6d-bdca-41ef-b8a4-6677a436120a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "320246b3-b7be-4e08-960b-ff6a7dff2ba8", false, "AQAAAAEAACcQAAAAEBaBovBvJkFnJprlEXP/ev+3uMNPRcM2BXLUXcpLHbtosimanRky9NlKcEVCovRhsg==", "01c16d1b-6065-4e93-aae1-333bfbbd58f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e0dc9dc-985f-4e83-860a-b1d67d75a1aa", false, "AQAAAAEAACcQAAAAEB0QN7E7RdHxJzA8u1l/+K7k5wZOgl7WCRoM/M/Iz49fmnA05woW5uKDLJCDVWKukA==", "b4d08616-1e68-44af-b57e-dd1a3a003cf8" });
        }
    }
}
