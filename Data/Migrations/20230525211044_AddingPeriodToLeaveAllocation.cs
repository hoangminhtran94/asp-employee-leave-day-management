using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace first_asp_app.Data.Migrations
{
    public partial class AddingPeriodToLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1c3d0235-686f-44db-a427-aeb2e6d96ffb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f7dccfd1-7b44-4874-a6ee-e2f84e8579ad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d633f106-f1b9-4d9b-a862-db7435b3cfbe", "AQAAAAEAACcQAAAAELWnRUZ99GEWQZIGMWQeEpvEDD+bj/v9H1RUUUmfAn4OlDDHxgNd4AJ3qOA96w4FKQ==", "f60986ef-0fcb-47bc-a420-7cefa5311a96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bffd5229-f0a7-4dbf-97c7-42c4991e3af8", "AQAAAAEAACcQAAAAEEkJYDoaA0TZ8O8K+YEUV0iwx2xO+DvtrpBdAiXzItzTOMVV6aKnxzYEhe/20nRVGw==", "c95f1420-4ee1-46c5-b17b-1aeb1c55067f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cd8e6ba-7bd3-43bb-86db-61f53ddf4ef8", "AQAAAAEAACcQAAAAELKlX7ftNDDcEWQ3MDBE4Jc6zmy4tO+9MChRpMFwg3D9kRWvjrTNXKw4fQK4qBq/Hg==", "d835bb09-ff9e-40c7-84f2-b8c0ebb5d3ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce5d3e0e-3608-45f6-81cc-cf1e1eaac16b", "AQAAAAEAACcQAAAAEAoqnAPr9k0kl6zg9Mr30LzMPm4fCL0d2f9UKOPi3aX++1VnfJn/gw0jLxYDSMQj+w==", "21821510-39eb-420d-904a-43431b2c328d" });
        }
    }
}
