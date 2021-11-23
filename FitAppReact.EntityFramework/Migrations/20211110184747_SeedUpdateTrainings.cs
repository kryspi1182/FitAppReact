using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAppReact.EntityFramework.Migrations
{
    public partial class SeedUpdateTrainings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ed68a3b-d23e-4827-b979-51b7ca4081fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65b3f8f8-a2c7-4ee6-8968-afe7ffbf0a11");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ba49c38-f88b-4593-bb80-4f07175c64d7", "d96b4597-2603-439b-afce-d1a49e10c221", "User", null },
                    { "d85308da-f3c2-49e6-a5ac-b491a017cb77", "16716513-1fb7-4c0f-ba5a-3da904350729", "Administrator", null }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyId", "ExerciseCategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, 1, "Light jog" },
                    { 2, 1, 2, "Bicep curls" },
                    { 3, 1, 3, "Arm stretch" },
                    { 4, 1, 1, "Jumping rope" },
                    { 5, 2, 2, "Squats" },
                    { 6, 1, 3, "Bends" }
                });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Description", "DifficultyId", "Name", "TrainingCategoryId" },
                values: new object[,]
                {
                    { 1, "Beginner friendly workout aiming to grow one of the most popular muscles - biceps.", 1, "Bicepz gainz", 7 },
                    { 2, "Get dem quads going bois", 1, "Quads for days", 7 }
                });

            migrationBuilder.InsertData(
                table: "ExerciseBodyTargets",
                columns: new[] { "Id", "BodyTargetId", "ExerciseId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 11, 2, 6 },
                    { 10, 6, 5 },
                    { 8, 2, 5 },
                    { 7, 3, 4 },
                    { 9, 5, 5 },
                    { 5, 1, 4 },
                    { 4, 5, 3 },
                    { 3, 3, 3 },
                    { 2, 3, 2 },
                    { 6, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "TrainingExercises",
                columns: new[] { "Id", "ExerciseId", "RepsPerSeries", "Series", "TrainingId" },
                values: new object[,]
                {
                    { 5, 5, 10, 10, 2 },
                    { 1, 4, 1, 10, 1 },
                    { 2, 2, 20, 5, 1 },
                    { 3, 3, 10, 10, 1 },
                    { 4, 1, 30, 10, 2 },
                    { 6, 6, 10, 10, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ba49c38-f88b-4593-bb80-4f07175c64d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d85308da-f3c2-49e6-a5ac-b491a017cb77");

            migrationBuilder.DeleteData(
                table: "ExerciseBodyTargets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExerciseBodyTargets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExerciseBodyTargets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExerciseBodyTargets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExerciseBodyTargets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExerciseBodyTargets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExerciseBodyTargets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExerciseBodyTargets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExerciseBodyTargets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExerciseBodyTargets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExerciseBodyTargets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TrainingExercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrainingExercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrainingExercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrainingExercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrainingExercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrainingExercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65b3f8f8-a2c7-4ee6-8968-afe7ffbf0a11", "df012635-ab40-4e4b-b3ee-52994b0ad5be", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ed68a3b-d23e-4827-b979-51b7ca4081fd", "b2326a7b-8bc4-457c-811d-a65239f566cc", "Administrator", null });
        }
    }
}
