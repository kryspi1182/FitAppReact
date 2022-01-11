//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAppReact.EntityFramework.Migrations
{
    public partial class AddTrainingModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "238586d7-a231-46ff-aaaa-1d73e85eae2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f18a177-c58d-4c27-b6cf-caf49780f25f");

            migrationBuilder.CreateTable(
                name: "BodyTargets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyTargets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Difficulties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Difficulties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingConditionSeverities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingConditionSeverities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExerciseCategoryId = table.Column<int>(type: "int", nullable: false),
                    DifficultyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_Difficulties_DifficultyId",
                        column: x => x.DifficultyId,
                        principalTable: "Difficulties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exercises_ExerciseCategories_ExerciseCategoryId",
                        column: x => x.ExerciseCategoryId,
                        principalTable: "ExerciseCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingCategoryId = table.Column<int>(type: "int", nullable: false),
                    DifficultyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainings_Difficulties_DifficultyId",
                        column: x => x.DifficultyId,
                        principalTable: "Difficulties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trainings_TrainingCategories_TrainingCategoryId",
                        column: x => x.TrainingCategoryId,
                        principalTable: "TrainingCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTrainingConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BodyTargetId = table.Column<int>(type: "int", nullable: false),
                    TrainingConditionSeverityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTrainingConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTrainingConditions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserTrainingConditions_BodyTargets_BodyTargetId",
                        column: x => x.BodyTargetId,
                        principalTable: "BodyTargets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTrainingConditions_TrainingConditionSeverities_TrainingConditionSeverityId",
                        column: x => x.TrainingConditionSeverityId,
                        principalTable: "TrainingConditionSeverities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseBodyTargets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    BodyTargetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseBodyTargets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseBodyTargets_BodyTargets_BodyTargetId",
                        column: x => x.BodyTargetId,
                        principalTable: "BodyTargets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseBodyTargets_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Series = table.Column<int>(type: "int", nullable: false),
                    RepsPerSeries = table.Column<int>(type: "int", nullable: false),
                    TrainingId = table.Column<int>(type: "int", nullable: true),
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingExercises_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingExercises_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "79ccb0ef-da7d-4b6a-8738-2d18ea93bb73", "b00abb16-d62d-479c-9399-e2a471b23f38", "Administrator", null },
                    { "ef7b21fc-c5d7-47cc-b63c-11d7429485cc", "1881cc10-22b1-48ed-9c77-492b5a5022b4", "User", null }
                });

            migrationBuilder.InsertData(
                table: "BodyTargets",
                columns: new[] { "Id", "Target" },
                values: new object[,]
                {
                    { 6, "Stomach" },
                    { 5, "Back" },
                    { 1, "Cardio" },
                    { 3, "Arms" },
                    { 4, "Chest" },
                    { 2, "Legs" }
                });

            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "You have next to no experience in sports/workouts. That's okay, you've begun your journey, every athlete has at some point.", "Beginner" },
                    { 2, "You've exercised before, you know the basics, nothing fancy but we'll change that.", "Intermediate" },
                    { 3, "You feel confident while working out, you are aware of your body, you know what are you doing and what you want to achieve and you want to keep moving forward.", "Advanced" },
                    { 4, "You know why you're here, no need for introductions, let's get to work.", "Professional" }
                });

            migrationBuilder.InsertData(
                table: "ExerciseCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 3, "Stretching is an important element of every training. Stretching before working out can provide better results, due to muscles being ready and unlocked. Also reduces risks of muscle, tendons and joint injuries.", "Stretch" },
                    { 1, "Exercises meant to prepare your body for the training. Mainly cardio exercises to force faster heart rate and heavier breathing.", "Warmup" },
                    { 2, "The main course. Exercises which will help rebuild your body the way you want and put in effort.", "Main" }
                });

            migrationBuilder.InsertData(
                table: "TrainingCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Maintain the heart rate at a desired level. Examples are: running, swimming, cycling etc.", "Continuous" },
                    { 3, "Training which involves completing short sets of different exercises one after the other. Example: burpess, press ups, sit ups, squats, rest, repeat.", "Circuit" },
                    { 4, "Training with periods of rest mixed with high intensity exercises. Example: 50m sprint, 30 seconds rest, repeat 10 times.", "Interval" },
                    { 5, "Training which involves short bursts of very high intensity. Example: box jumps.", "Plyometric" },
                    { 6, "Training focused on improving range of motion. Example: calf raise.", "Flexibility" },
                    { 7, "Training focused on muscle movement with additional resistance in the form of a heavy weight. If exercises are not done correctly, there is a serious risk of injury.", "Weight" },
                    { 2, "Training which uses periods of high intensity, low intensity and rest. Example: full sprint for 10 seconds, walk for 1 minute, jog for 2 minutes, repeat.", "Fartlek" }
                });

            migrationBuilder.InsertData(
                table: "TrainingConditionSeverities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A condition you almost forgot about. Nothing to worry, yet better be safe than sorry. Exercises affecting the body part will be highlighted so you know what to observe more carefully.", "Unnoticable" },
                    { 2, "Nothing serious, yet you are aware something is not 100% good. Exercises highlighted in yellow should be done with caution, listen to your body and in case anything is wrong, lower the intensity or even leave it alone. Focus on your health, without it there won't be any gains.", "Mild" },
                    { 3, "A serious condition that affects the ability to use said body part. Exercises affecting the chosen body part will not be listed for you. Health should always be a top priority. If you are looking for rehab exercises, we reccomend consulting a specialist.", "Severe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseBodyTargets_BodyTargetId",
                table: "ExerciseBodyTargets",
                column: "BodyTargetId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseBodyTargets_ExerciseId",
                table: "ExerciseBodyTargets",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_DifficultyId",
                table: "Exercises",
                column: "DifficultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseCategoryId",
                table: "Exercises",
                column: "ExerciseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingExercises_ExerciseId",
                table: "TrainingExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingExercises_TrainingId",
                table: "TrainingExercises",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_DifficultyId",
                table: "Trainings",
                column: "DifficultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_TrainingCategoryId",
                table: "Trainings",
                column: "TrainingCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTrainingConditions_BodyTargetId",
                table: "UserTrainingConditions",
                column: "BodyTargetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTrainingConditions_TrainingConditionSeverityId",
                table: "UserTrainingConditions",
                column: "TrainingConditionSeverityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTrainingConditions_UserId",
                table: "UserTrainingConditions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseBodyTargets");

            migrationBuilder.DropTable(
                name: "TrainingExercises");

            migrationBuilder.DropTable(
                name: "UserTrainingConditions");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "BodyTargets");

            migrationBuilder.DropTable(
                name: "TrainingConditionSeverities");

            migrationBuilder.DropTable(
                name: "ExerciseCategories");

            migrationBuilder.DropTable(
                name: "Difficulties");

            migrationBuilder.DropTable(
                name: "TrainingCategories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79ccb0ef-da7d-4b6a-8738-2d18ea93bb73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef7b21fc-c5d7-47cc-b63c-11d7429485cc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f18a177-c58d-4c27-b6cf-caf49780f25f", "576d156d-abeb-4b1f-8916-a5959835e9d0", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "238586d7-a231-46ff-aaaa-1d73e85eae2f", "5f6e6854-cee9-4981-95ac-fc42e7d14f86", "Administrator", null });
        }
    }
}
