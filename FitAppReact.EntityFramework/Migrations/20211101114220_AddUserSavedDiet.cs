using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAppReact.EntityFramework.Migrations
{
    public partial class AddUserSavedDiet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e746d60-a8f9-4ad9-a3ce-f1794fa1a4bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f05d19e-0da7-4ea1-b57e-b67a72b8657e");

            migrationBuilder.CreateTable(
                name: "UserSavedDiets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSavedDiets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSavedDiets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSavedDietMeals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserSavedDietId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSavedDietMeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSavedDietMeals_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSavedDietMeals_UserSavedDiets_UserSavedDietId",
                        column: x => x.UserSavedDietId,
                        principalTable: "UserSavedDiets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f18a177-c58d-4c27-b6cf-caf49780f25f", "576d156d-abeb-4b1f-8916-a5959835e9d0", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "238586d7-a231-46ff-aaaa-1d73e85eae2f", "5f6e6854-cee9-4981-95ac-fc42e7d14f86", "Administrator", null });

            migrationBuilder.CreateIndex(
                name: "IX_UserSavedDietMeals_MealId",
                table: "UserSavedDietMeals",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSavedDietMeals_UserSavedDietId",
                table: "UserSavedDietMeals",
                column: "UserSavedDietId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSavedDiets_UserId",
                table: "UserSavedDiets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSavedDietMeals");

            migrationBuilder.DropTable(
                name: "UserSavedDiets");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "238586d7-a231-46ff-aaaa-1d73e85eae2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f18a177-c58d-4c27-b6cf-caf49780f25f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e746d60-a8f9-4ad9-a3ce-f1794fa1a4bb", "a7873aab-5fa7-490d-82ad-a4a3c35dcfbc", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f05d19e-0da7-4ea1-b57e-b67a72b8657e", "63c69185-be3c-4f06-8b7b-eb401be88fc0", "Administrator", null });
        }
    }
}
