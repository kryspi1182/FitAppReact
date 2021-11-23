using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAppReact.EntityFramework.Migrations
{
    public partial class AddUserTrainings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a9e33cc-8094-4766-af0b-48dcc17b774a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d54f0ced-9043-4b59-b55b-d4cf5291a523");

            migrationBuilder.CreateTable(
                name: "UserSavedTrainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TrainingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSavedTrainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSavedTrainings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSavedTrainings_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98db12b6-24af-4e97-9e88-982abe839e3c", "1e4a8bc8-0d0d-44ba-b56b-b7eb671164de", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26669b34-9837-4d53-b272-012f0f1ae024", "bffb85a0-7afa-4ac9-bd3c-65f7ccb82534", "Administrator", null });

            migrationBuilder.CreateIndex(
                name: "IX_UserSavedTrainings_TrainingId",
                table: "UserSavedTrainings",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSavedTrainings_UserId",
                table: "UserSavedTrainings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSavedTrainings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26669b34-9837-4d53-b272-012f0f1ae024");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98db12b6-24af-4e97-9e88-982abe839e3c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3a9e33cc-8094-4766-af0b-48dcc17b774a", "f73d6136-0c40-4c29-bd44-791b099b67ad", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d54f0ced-9043-4b59-b55b-d4cf5291a523", "c256b22a-a742-4d46-8f6f-d0dc12085208", "Administrator", null });
        }
    }
}
