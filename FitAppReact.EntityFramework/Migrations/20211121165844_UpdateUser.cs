//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAppReact.EntityFramework.Migrations
{
    public partial class UpdateUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c058421a-1968-4084-b02b-4f5960083c2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0a7cdac-e17b-4d71-9b9c-04e61f6f7e16");

            migrationBuilder.AddColumn<int>(
                name: "DifficultyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1416bb4e-78bb-4711-b6f9-72d27bf4181e", "82338267-3605-49aa-92f5-cc06d16edc81", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8aaa542-bd77-478b-9a65-e3cf22d768bd", "0bb10cd3-dfe8-4374-a2a2-11520dd3f68c", "Administrator", null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DifficultyId",
                table: "AspNetUsers",
                column: "DifficultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Difficulties_DifficultyId",
                table: "AspNetUsers",
                column: "DifficultyId",
                principalTable: "Difficulties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Difficulties_DifficultyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DifficultyId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1416bb4e-78bb-4711-b6f9-72d27bf4181e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8aaa542-bd77-478b-9a65-e3cf22d768bd");

            migrationBuilder.DropColumn(
                name: "DifficultyId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c058421a-1968-4084-b02b-4f5960083c2f", "234424c7-90b6-4351-b9f1-f7de911c5f34", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0a7cdac-e17b-4d71-9b9c-04e61f6f7e16", "685ff195-13a5-4165-9aab-e062b0934206", "Administrator", null });
        }
    }
}
