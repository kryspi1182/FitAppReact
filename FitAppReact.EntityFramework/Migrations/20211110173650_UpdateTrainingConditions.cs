//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAppReact.EntityFramework.Migrations
{
    public partial class UpdateTrainingConditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTrainingConditions_BodyTargets_BodyTargetId",
                table: "UserTrainingConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTrainingConditions_TrainingConditionSeverities_TrainingConditionSeverityId",
                table: "UserTrainingConditions");

            migrationBuilder.DropIndex(
                name: "IX_UserTrainingConditions_BodyTargetId",
                table: "UserTrainingConditions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79ccb0ef-da7d-4b6a-8738-2d18ea93bb73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef7b21fc-c5d7-47cc-b63c-11d7429485cc");

            migrationBuilder.DropColumn(
                name: "BodyTargetId",
                table: "UserTrainingConditions");

            migrationBuilder.RenameColumn(
                name: "TrainingConditionSeverityId",
                table: "UserTrainingConditions",
                newName: "TrainingConditionId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTrainingConditions_TrainingConditionSeverityId",
                table: "UserTrainingConditions",
                newName: "IX_UserTrainingConditions_TrainingConditionId");

            migrationBuilder.CreateTable(
                name: "TrainingCondition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyTargetId = table.Column<int>(type: "int", nullable: false),
                    TrainingConditionSeverityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingCondition_BodyTargets_BodyTargetId",
                        column: x => x.BodyTargetId,
                        principalTable: "BodyTargets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingCondition_TrainingConditionSeverities_TrainingConditionSeverityId",
                        column: x => x.TrainingConditionSeverityId,
                        principalTable: "TrainingConditionSeverities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2ed68a3b-d23e-4827-b979-51b7ca4081fd", "b2326a7b-8bc4-457c-811d-a65239f566cc", "Administrator", null },
                    { "65b3f8f8-a2c7-4ee6-8968-afe7ffbf0a11", "df012635-ab40-4e4b-b3ee-52994b0ad5be", "User", null }
                });

            migrationBuilder.InsertData(
                table: "TrainingCondition",
                columns: new[] { "Id", "BodyTargetId", "TrainingConditionSeverityId" },
                values: new object[,]
                {
                    { 18, 6, 3 },
                    { 17, 6, 2 },
                    { 16, 6, 1 },
                    { 15, 5, 3 },
                    { 14, 5, 2 },
                    { 13, 5, 1 },
                    { 12, 4, 3 },
                    { 11, 4, 2 },
                    { 10, 4, 1 },
                    { 8, 3, 2 },
                    { 7, 3, 1 },
                    { 6, 2, 3 },
                    { 5, 2, 2 },
                    { 4, 2, 1 },
                    { 3, 1, 3 },
                    { 2, 1, 2 },
                    { 9, 3, 3 },
                    { 1, 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCondition_BodyTargetId",
                table: "TrainingCondition",
                column: "BodyTargetId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCondition_TrainingConditionSeverityId",
                table: "TrainingCondition",
                column: "TrainingConditionSeverityId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTrainingConditions_TrainingCondition_TrainingConditionId",
                table: "UserTrainingConditions",
                column: "TrainingConditionId",
                principalTable: "TrainingCondition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTrainingConditions_TrainingCondition_TrainingConditionId",
                table: "UserTrainingConditions");

            migrationBuilder.DropTable(
                name: "TrainingCondition");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ed68a3b-d23e-4827-b979-51b7ca4081fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65b3f8f8-a2c7-4ee6-8968-afe7ffbf0a11");

            migrationBuilder.RenameColumn(
                name: "TrainingConditionId",
                table: "UserTrainingConditions",
                newName: "TrainingConditionSeverityId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTrainingConditions_TrainingConditionId",
                table: "UserTrainingConditions",
                newName: "IX_UserTrainingConditions_TrainingConditionSeverityId");

            migrationBuilder.AddColumn<int>(
                name: "BodyTargetId",
                table: "UserTrainingConditions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef7b21fc-c5d7-47cc-b63c-11d7429485cc", "1881cc10-22b1-48ed-9c77-492b5a5022b4", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "79ccb0ef-da7d-4b6a-8738-2d18ea93bb73", "b00abb16-d62d-479c-9399-e2a471b23f38", "Administrator", null });

            migrationBuilder.CreateIndex(
                name: "IX_UserTrainingConditions_BodyTargetId",
                table: "UserTrainingConditions",
                column: "BodyTargetId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTrainingConditions_BodyTargets_BodyTargetId",
                table: "UserTrainingConditions",
                column: "BodyTargetId",
                principalTable: "BodyTargets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTrainingConditions_TrainingConditionSeverities_TrainingConditionSeverityId",
                table: "UserTrainingConditions",
                column: "TrainingConditionSeverityId",
                principalTable: "TrainingConditionSeverities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
