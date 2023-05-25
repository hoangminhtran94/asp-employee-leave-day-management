using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace first_asp_app.Data.Migrations
{
    public partial class UpdatedDefaultUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "320246b3-b7be-4e08-960b-ff6a7dff2ba8", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEBaBovBvJkFnJprlEXP/ev+3uMNPRcM2BXLUXcpLHbtosimanRky9NlKcEVCovRhsg==", "01c16d1b-6065-4e93-aae1-333bfbbd58f6", "admin@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3e0dc9dc-985f-4e83-860a-b1d67d75a1aa", "USER@TEST.COM", "AQAAAAEAACcQAAAAEB0QN7E7RdHxJzA8u1l/+K7k5wZOgl7WCRoM/M/Iz49fmnA05woW5uKDLJCDVWKukA==", "b4d08616-1e68-44af-b57e-dd1a3a003cf8", "USER@TEST.COM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d526a0ae-ae00-41a7-91ef-be789be25d11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "ec8975cf-1951-481a-a115-b5db3b823a0b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d5461f7d-d51a-4ccf-932e-91a26c597608", null, "AQAAAAEAACcQAAAAEPzm2nnvjyX0cmTnbNGmR/IOIs25xwEkDIPYe+QtY5Cqv+g1D9A32gqqWPjwAeGdbw==", "981ef174-b118-46c7-9143-fce289ac4795", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7ae1a876-01c4-43e4-9026-88ef0206f5d0", null, "AQAAAAEAACcQAAAAEOZKE2tnhrfyI7xuRVyD2esTHIyBxfnl+6KpiC+hIn0kTK4/tXUFRYmavn4YVc4ICg==", "31ca3984-a627-4cc1-89b4-1c8a2e78002e", null });
        }
    }
}
