using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAppReact.EntityFramework.Migrations
{
    public partial class TrainingConditionsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingCondition_BodyTargets_BodyTargetId",
                table: "TrainingCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingCondition_TrainingConditionSeverities_TrainingConditionSeverityId",
                table: "TrainingCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTrainingConditions_TrainingCondition_TrainingConditionId",
                table: "UserTrainingConditions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingCondition",
                table: "TrainingCondition");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26669b34-9837-4d53-b272-012f0f1ae024");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98db12b6-24af-4e97-9e88-982abe839e3c");

            migrationBuilder.RenameTable(
                name: "TrainingCondition",
                newName: "TrainingConditions");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingCondition_TrainingConditionSeverityId",
                table: "TrainingConditions",
                newName: "IX_TrainingConditions_TrainingConditionSeverityId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingCondition_BodyTargetId",
                table: "TrainingConditions",
                newName: "IX_TrainingConditions_BodyTargetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingConditions",
                table: "TrainingConditions",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c058421a-1968-4084-b02b-4f5960083c2f", "234424c7-90b6-4351-b9f1-f7de911c5f34", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0a7cdac-e17b-4d71-9b9c-04e61f6f7e16", "685ff195-13a5-4165-9aab-e062b0934206", "Administrator", null });

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingConditions_BodyTargets_BodyTargetId",
                table: "TrainingConditions",
                column: "BodyTargetId",
                principalTable: "BodyTargets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingConditions_TrainingConditionSeverities_TrainingConditionSeverityId",
                table: "TrainingConditions",
                column: "TrainingConditionSeverityId",
                principalTable: "TrainingConditionSeverities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTrainingConditions_TrainingConditions_TrainingConditionId",
                table: "UserTrainingConditions",
                column: "TrainingConditionId",
                principalTable: "TrainingConditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingConditions_BodyTargets_BodyTargetId",
                table: "TrainingConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingConditions_TrainingConditionSeverities_TrainingConditionSeverityId",
                table: "TrainingConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTrainingConditions_TrainingConditions_TrainingConditionId",
                table: "UserTrainingConditions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingConditions",
                table: "TrainingConditions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c058421a-1968-4084-b02b-4f5960083c2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0a7cdac-e17b-4d71-9b9c-04e61f6f7e16");

            migrationBuilder.RenameTable(
                name: "TrainingConditions",
                newName: "TrainingCondition");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingConditions_TrainingConditionSeverityId",
                table: "TrainingCondition",
                newName: "IX_TrainingCondition_TrainingConditionSeverityId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingConditions_BodyTargetId",
                table: "TrainingCondition",
                newName: "IX_TrainingCondition_BodyTargetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingCondition",
                table: "TrainingCondition",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98db12b6-24af-4e97-9e88-982abe839e3c", "1e4a8bc8-0d0d-44ba-b56b-b7eb671164de", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26669b34-9837-4d53-b272-012f0f1ae024", "bffb85a0-7afa-4ac9-bd3c-65f7ccb82534", "Administrator", null });

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingCondition_BodyTargets_BodyTargetId",
                table: "TrainingCondition",
                column: "BodyTargetId",
                principalTable: "BodyTargets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingCondition_TrainingConditionSeverities_TrainingConditionSeverityId",
                table: "TrainingCondition",
                column: "TrainingConditionSeverityId",
                principalTable: "TrainingConditionSeverities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTrainingConditions_TrainingCondition_TrainingConditionId",
                table: "UserTrainingConditions",
                column: "TrainingConditionId",
                principalTable: "TrainingCondition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
