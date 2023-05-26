using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace first_asp_app.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "leaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: true),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_leaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a66bc0b6-bb3d-48ab-8cb5-cb8530ff5de6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4800e555-7357-4b17-a1a3-ef4212635f16");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef6600c4-ee84-4a81-8e6e-f7592a679238", "AQAAAAEAACcQAAAAEDpK/c46mwZxE8kETyr+ONJUxpYyl11slIUI488hr4IedhtDqEiI+oddv2CgLs/60Q==", "ea0d09f5-d08a-41ba-975d-3f2008035a95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec5bf587-b21a-449c-b9dd-0858b7eca5fe", "AQAAAAEAACcQAAAAEMZSkXkCIPqFVRuCbcDwkt3DpRILy4f/chuNWVyxAadUm7JuBMpqo4woIa5ym90jJg==", "6fd35eb1-5d8d-4aa8-8852-c9ca868d6f83" });

            migrationBuilder.CreateIndex(
                name: "IX_leaveRequests_LeaveTypeId",
                table: "leaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "leaveRequests");

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
    }
}
