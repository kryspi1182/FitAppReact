//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAppReact.EntityFramework.Migrations
{
    public partial class AddWeightTargets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1416bb4e-78bb-4711-b6f9-72d27bf4181e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8aaa542-bd77-478b-9a65-e3cf22d768bd");

            migrationBuilder.AddColumn<int>(
                name: "WeightTargetId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WeightTargets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightTargets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c7ab1f5a-5e73-443e-ba2a-aed71425ff0f", "774406ac-5427-4326-8fc5-b617c7fc9220", "User", null },
                    { "f3addf13-5567-4f30-8bd1-7a9a6ac638c9", "edaeeae4-f2b9-46fe-be36-4ddb1e3810d5", "Administrator", null }
                });

            migrationBuilder.InsertData(
                table: "WeightTargets",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Lose weight" },
                    { 2, "Maintain weight" },
                    { 3, "Gain weight" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_WeightTargetId",
                table: "AspNetUsers",
                column: "WeightTargetId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_WeightTargets_WeightTargetId",
                table: "AspNetUsers",
                column: "WeightTargetId",
                principalTable: "WeightTargets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_WeightTargets_WeightTargetId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "WeightTargets");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_WeightTargetId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7ab1f5a-5e73-443e-ba2a-aed71425ff0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3addf13-5567-4f30-8bd1-7a9a6ac638c9");

            migrationBuilder.DropColumn(
                name: "WeightTargetId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1416bb4e-78bb-4711-b6f9-72d27bf4181e", "82338267-3605-49aa-92f5-cc06d16edc81", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8aaa542-bd77-478b-9a65-e3cf22d768bd", "0bb10cd3-dfe8-4374-a2a2-11520dd3f68c", "Administrator", null });
        }
    }
}
