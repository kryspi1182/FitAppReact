//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAppReact.EntityFramework.Migrations
{
    public partial class SeedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Quantity",
                table: "MealProducts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Hazards",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "High amounts of sugar", "Sugar" },
                    { 2, "Presence of lactose", "Lactose" },
                    { 3, "Presence of nuts", "Nuts" }
                });

            migrationBuilder.InsertData(
                table: "MealCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Breakfast/Dinner" },
                    { 2, "Lunch" },
                    { 3, "Snack" }
                });

            migrationBuilder.InsertData(
                table: "MedicalConditions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Avoid sugars", "Diabetes" },
                    { 2, "Avoid lactose", "Lactose intolerance" },
                    { 3, "Avoid nuts", "Nut allergy" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Description", "MealCategoryId", "Name", "Recipe" },
                values: new object[,]
                {
                    { 10, "Description of dinner 5", 1, "Dinner 5", "Recipe of dinner 5" },
                    { 15, "Description of lunch 5", 2, "Lunch 5", "Recipe of lunch 5" },
                    { 14, "Description of lunch 4", 2, "Lunch 4", "Recipe of lunch 4" },
                    { 13, "Description of lunch 3", 2, "Lunch 3", "Recipe of lunch 3" },
                    { 12, "Description of lunch 2", 2, "Lunch 2", "Recipe of lunch 2" },
                    { 11, "Description of lunch 1", 2, "Lunch 1", "Recipe of lunch 1" },
                    { 18, "Description of snack 3", 3, "Snack 3", "Recipe of snack 3" },
                    { 9, "Description of dinner 4", 1, "Dinner 4", "Recipe of dinner 4" },
                    { 8, "Description of dinner 3", 1, "Dinner 3", "Recipe of dinner 3" },
                    { 16, "Description of snack 1", 3, "Snack 1", "Recipe of snack 1" },
                    { 7, "Description of dinner 2", 1, "Dinner 2", "Recipe of dinner 2" },
                    { 5, "Description of breakfast 5", 1, "Breakfast 5", "Recipe of breakfast 5" },
                    { 4, "Description of breakfast 4", 1, "Breakfast 4", "Recipe of breakfast 4" },
                    { 3, "Description of breakfast 3", 1, "Breakfast 3", "Recipe of breakfast 3" },
                    { 2, "Description of breakfast 2", 1, "Breakfast 2", "Recipe of breakfast 2" },
                    { 1, "Description of breakfast 1", 1, "Breakfast 1", "Recipe of breakfast 1" },
                    { 19, "Description of snack 4", 3, "Snack 4", "Recipe of snack 4" },
                    { 20, "Description of snack 5", 3, "Snack 5", "Recipe of snack 5" },
                    { 6, "Description of dinner 1", 1, "Dinner 1", "Recipe of dinner 1" },
                    { 17, "Description of snack 2", 3, "Snack 2", "Recipe of snack 2" }
                });

            migrationBuilder.InsertData(
                table: "MedicalConditionHazards",
                columns: new[] { "Id", "HazardId", "MedicalConditionId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 3, 3, 3 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductHazards",
                columns: new[] { "Id", "HazardId", "ProductId" },
                values: new object[,]
                {
                    { 4, 3, 1 },
                    { 3, 2, 36 },
                    { 2, 1, 30 },
                    { 1, 1, 29 }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 4, 2m },
                    { 33, 11, 29, 3m },
                    { 34, 12, 5, 1m },
                    { 35, 12, 19, 2m },
                    { 36, 12, 33, 1m },
                    { 37, 13, 28, 1m },
                    { 38, 13, 17, 3m },
                    { 39, 13, 5, 2m },
                    { 40, 14, 9, 1m },
                    { 41, 14, 4, 1m },
                    { 42, 14, 15, 3m },
                    { 43, 15, 7, 2m },
                    { 44, 15, 23, 1m },
                    { 32, 11, 37, 3m },
                    { 45, 15, 18, 3m },
                    { 47, 16, 10, 2m },
                    { 48, 16, 21, 1m },
                    { 49, 17, 36, 1m },
                    { 50, 17, 36, 3m },
                    { 51, 17, 6, 1m },
                    { 52, 18, 29, 1m },
                    { 53, 18, 37, 1m },
                    { 54, 18, 8, 2m },
                    { 55, 19, 30, 3m },
                    { 56, 19, 25, 2m },
                    { 57, 19, 30, 1m },
                    { 58, 20, 28, 2m },
                    { 46, 16, 5, 1m },
                    { 31, 11, 20, 2m },
                    { 30, 10, 15, 3m },
                    { 29, 10, 5, 1m },
                    { 2, 1, 28, 3m },
                    { 3, 1, 4, 3m },
                    { 4, 2, 30, 3m },
                    { 5, 2, 24, 2m },
                    { 6, 2, 7, 2m },
                    { 7, 3, 15, 1m },
                    { 8, 3, 30, 3m },
                    { 9, 3, 35, 3m },
                    { 10, 4, 12, 1m },
                    { 11, 4, 30, 2m },
                    { 12, 4, 9, 3m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 13, 5, 17, 1m },
                    { 14, 5, 14, 1m },
                    { 15, 5, 28, 3m },
                    { 16, 6, 23, 2m },
                    { 17, 6, 12, 1m },
                    { 18, 6, 24, 1m },
                    { 19, 7, 4, 2m },
                    { 20, 7, 8, 1m },
                    { 21, 7, 26, 3m },
                    { 22, 8, 9, 3m },
                    { 23, 8, 18, 1m },
                    { 24, 8, 6, 1m },
                    { 25, 9, 31, 3m },
                    { 26, 9, 20, 3m },
                    { 27, 9, 31, 1m },
                    { 28, 10, 29, 3m },
                    { 59, 20, 8, 1m },
                    { 60, 20, 28, 1m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "MedicalConditionHazards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicalConditionHazards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MedicalConditionHazards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductHazards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductHazards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductHazards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductHazards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hazards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hazards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hazards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MedicalConditions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicalConditions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MedicalConditions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MealCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MealCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "MealProducts");
        }
    }
}
