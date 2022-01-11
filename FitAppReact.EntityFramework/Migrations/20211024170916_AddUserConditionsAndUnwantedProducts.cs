//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAppReact.EntityFramework.Migrations
{
    public partial class AddUserConditionsAndUnwantedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65178827-e419-48af-93a3-3838b1685e3e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccb965a5-29e4-4961-b023-e04e7eb23dfa");

            migrationBuilder.CreateTable(
                name: "UserMedicalConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MedicalConditionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMedicalConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMedicalConditions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserMedicalConditions_MedicalConditions_MedicalConditionId",
                        column: x => x.MedicalConditionId,
                        principalTable: "MedicalConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserUnwantedProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserUnwantedProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserUnwantedProducts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserUnwantedProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e746d60-a8f9-4ad9-a3ce-f1794fa1a4bb", "a7873aab-5fa7-490d-82ad-a4a3c35dcfbc", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f05d19e-0da7-4ea1-b57e-b67a72b8657e", "63c69185-be3c-4f06-8b7b-eb401be88fc0", "Administrator", null });

            migrationBuilder.CreateIndex(
                name: "IX_UserMedicalConditions_MedicalConditionId",
                table: "UserMedicalConditions",
                column: "MedicalConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMedicalConditions_UserId",
                table: "UserMedicalConditions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserUnwantedProducts_ProductId",
                table: "UserUnwantedProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UserUnwantedProducts_UserId",
                table: "UserUnwantedProducts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserMedicalConditions");

            migrationBuilder.DropTable(
                name: "UserUnwantedProducts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e746d60-a8f9-4ad9-a3ce-f1794fa1a4bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f05d19e-0da7-4ea1-b57e-b67a72b8657e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ccb965a5-29e4-4961-b023-e04e7eb23dfa", "df85760a-4beb-4f11-93f2-8c042407e781", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65178827-e419-48af-93a3-3838b1685e3e", "150e841c-f769-4e42-8f0f-26b2807feb44", "Administrator", null });
        }
    }
}
