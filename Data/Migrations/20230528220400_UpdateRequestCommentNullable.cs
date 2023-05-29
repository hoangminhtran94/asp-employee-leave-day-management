using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace first_asp_app.Data.Migrations
{
    public partial class UpdateRequestCommentNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "leaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4f61404a-3fc6-44c0-8112-b3b3f85f0f48");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6e37c732-2678-4828-b67c-0a4b3f332f22");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d86c6577-5e9d-4c39-815b-a6420a04a621", "AQAAAAEAACcQAAAAEOaL5DbHx5FwxVOJ7ZZBki9nMPklss+6/1SSim6oEgMa19S61iw77sOLwzOEjTLrSQ==", "0699d0d0-54a2-430f-a9b7-cabb4abe7d90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e60fa2f-c041-4b16-b174-5b797ff2de6e", "AQAAAAEAACcQAAAAEE3x5VABIT1fgBFjNPcUKmk7V5ypASImKR8FHbxTwmHBcjcUv5VSqVJcrPxyBlh8eQ==", "a55bb863-2d44-4b6b-b700-46337e7be509" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "leaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
