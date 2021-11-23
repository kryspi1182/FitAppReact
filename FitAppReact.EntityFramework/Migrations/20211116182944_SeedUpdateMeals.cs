using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAppReact.EntityFramework.Migrations
{
    public partial class SeedUpdateMeals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ba49c38-f88b-4593-bb80-4f07175c64d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d85308da-f3c2-49e6-a5ac-b491a017cb77");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a9e33cc-8094-4766-af0b-48dcc17b774a", "f73d6136-0c40-4c29-bd44-791b099b67ad", "User", null },
                    { "d54f0ced-9043-4b59-b55b-d4cf5291a523", "c256b22a-a742-4d46-8f6f-d0dc12085208", "Administrator", null }
                });

            migrationBuilder.UpdateData(
                table: "MealCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Breakfast");

            migrationBuilder.InsertData(
                table: "MealCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Second breakfast" },
                    { 5, "Dinner" }
                });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 6,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 7,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 8,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 9,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 10,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 101,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 102,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 103,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 104,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 105,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 106,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 107,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 108,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 109,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 110,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 111,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 112,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 113,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 114,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 115,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 116,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 117,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 118,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 119,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 120,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 121,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 122,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 123,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 124,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 125,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 126,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 127,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 128,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 129,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 130,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 131,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 132,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 133,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 134,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 135,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 136,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 137,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 138,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 139,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 140,
                column: "MealCategoryId",
                value: 5);

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Description", "MealCategoryId", "Name", "Recipe" },
                values: new object[,]
                {
                    { 260, "Description of Second breakfast 260", 4, "Second breakfast 260", "Recipe of Second breakfast 260" },
                    { 258, "Description of Second breakfast 258", 4, "Second breakfast 258", "Recipe of Second breakfast 258" },
                    { 234, "Description of Second breakfast 234", 4, "Second breakfast 234", "Recipe of Second breakfast 234" },
                    { 233, "Description of Second breakfast 233", 4, "Second breakfast 233", "Recipe of Second breakfast 233" },
                    { 232, "Description of Second breakfast 232", 4, "Second breakfast 232", "Recipe of Second breakfast 232" },
                    { 231, "Description of Second breakfast 231", 4, "Second breakfast 231", "Recipe of Second breakfast 231" },
                    { 230, "Description of Second breakfast 230", 4, "Second breakfast 230", "Recipe of Second breakfast 230" },
                    { 229, "Description of Second breakfast 229", 4, "Second breakfast 229", "Recipe of Second breakfast 229" },
                    { 228, "Description of Second breakfast 228", 4, "Second breakfast 228", "Recipe of Second breakfast 228" },
                    { 227, "Description of Second breakfast 227", 4, "Second breakfast 227", "Recipe of Second breakfast 227" },
                    { 235, "Description of Second breakfast 235", 4, "Second breakfast 235", "Recipe of Second breakfast 235" },
                    { 226, "Description of Second breakfast 226", 4, "Second breakfast 226", "Recipe of Second breakfast 226" },
                    { 224, "Description of Second breakfast 224", 4, "Second breakfast 224", "Recipe of Second breakfast 224" },
                    { 223, "Description of Second breakfast 223", 4, "Second breakfast 223", "Recipe of Second breakfast 223" },
                    { 222, "Description of Second breakfast 222", 4, "Second breakfast 222", "Recipe of Second breakfast 222" },
                    { 221, "Description of Second breakfast 221", 4, "Second breakfast 221", "Recipe of Second breakfast 221" },
                    { 25, "Description of Second breakfast 5", 4, "Second breakfast 5", "Recipe of Second breakfast 5" },
                    { 24, "Description of Second breakfast 4", 4, "Second breakfast 4", "Recipe of Second breakfast 4" },
                    { 23, "Description of Second breakfast 3", 4, "Second breakfast 3", "Recipe of Second breakfast 3" },
                    { 22, "Description of Second breakfast 2", 4, "Second breakfast 2", "Recipe of Second breakfast 2" },
                    { 225, "Description of Second breakfast 225", 4, "Second breakfast 225", "Recipe of Second breakfast 225" },
                    { 236, "Description of Second breakfast 236", 4, "Second breakfast 236", "Recipe of Second breakfast 236" },
                    { 237, "Description of Second breakfast 237", 4, "Second breakfast 237", "Recipe of Second breakfast 237" },
                    { 238, "Description of Second breakfast 238", 4, "Second breakfast 238", "Recipe of Second breakfast 238" },
                    { 257, "Description of Second breakfast 257", 4, "Second breakfast 257", "Recipe of Second breakfast 257" },
                    { 256, "Description of Second breakfast 256", 4, "Second breakfast 256", "Recipe of Second breakfast 256" },
                    { 255, "Description of Second breakfast 255", 4, "Second breakfast 255", "Recipe of Second breakfast 255" },
                    { 254, "Description of Second breakfast 254", 4, "Second breakfast 254", "Recipe of Second breakfast 254" },
                    { 253, "Description of Second breakfast 253", 4, "Second breakfast 253", "Recipe of Second breakfast 253" },
                    { 252, "Description of Second breakfast 252", 4, "Second breakfast 252", "Recipe of Second breakfast 252" },
                    { 251, "Description of Second breakfast 251", 4, "Second breakfast 251", "Recipe of Second breakfast 251" },
                    { 250, "Description of Second breakfast 250", 4, "Second breakfast 250", "Recipe of Second breakfast 250" },
                    { 249, "Description of Second breakfast 249", 4, "Second breakfast 249", "Recipe of Second breakfast 249" },
                    { 248, "Description of Second breakfast 248", 4, "Second breakfast 248", "Recipe of Second breakfast 248" },
                    { 247, "Description of Second breakfast 247", 4, "Second breakfast 247", "Recipe of Second breakfast 247" },
                    { 246, "Description of Second breakfast 246", 4, "Second breakfast 246", "Recipe of Second breakfast 246" },
                    { 245, "Description of Second breakfast 245", 4, "Second breakfast 245", "Recipe of Second breakfast 245" },
                    { 244, "Description of Second breakfast 244", 4, "Second breakfast 244", "Recipe of Second breakfast 244" },
                    { 243, "Description of Second breakfast 243", 4, "Second breakfast 243", "Recipe of Second breakfast 243" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Description", "MealCategoryId", "Name", "Recipe" },
                values: new object[,]
                {
                    { 242, "Description of Second breakfast 242", 4, "Second breakfast 242", "Recipe of Second breakfast 242" },
                    { 241, "Description of Second breakfast 241", 4, "Second breakfast 241", "Recipe of Second breakfast 241" },
                    { 240, "Description of Second breakfast 240", 4, "Second breakfast 240", "Recipe of Second breakfast 240" },
                    { 239, "Description of Second breakfast 239", 4, "Second breakfast 239", "Recipe of Second breakfast 239" },
                    { 259, "Description of Second breakfast 259", 4, "Second breakfast 259", "Recipe of Second breakfast 259" },
                    { 21, "Description of Second breakfast 1", 4, "Second breakfast 1", "Recipe of Second breakfast 1" }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 665, 21, 5, 1m },
                    { 628, 248, 25, 2m },
                    { 627, 248, 33, 1m },
                    { 626, 248, 17, 2m },
                    { 625, 247, 37, 3m },
                    { 624, 247, 14, 4m },
                    { 623, 247, 9, 3m },
                    { 622, 246, 8, 2m },
                    { 621, 246, 25, 4m },
                    { 620, 246, 15, 2m },
                    { 619, 245, 5, 3m },
                    { 618, 245, 1, 2m },
                    { 617, 245, 30, 4m },
                    { 616, 244, 6, 2m },
                    { 615, 244, 16, 1m },
                    { 629, 249, 9, 4m },
                    { 614, 244, 30, 1m },
                    { 612, 243, 29, 2m },
                    { 611, 243, 10, 2m },
                    { 610, 242, 36, 4m },
                    { 609, 242, 21, 4m },
                    { 608, 242, 36, 4m },
                    { 607, 241, 9, 4m },
                    { 606, 241, 18, 3m },
                    { 605, 241, 22, 3m },
                    { 604, 240, 30, 4m },
                    { 603, 240, 20, 3m },
                    { 602, 240, 4, 2m },
                    { 601, 239, 31, 3m },
                    { 600, 239, 18, 2m },
                    { 599, 239, 12, 4m },
                    { 613, 243, 2, 2m },
                    { 598, 238, 17, 2m },
                    { 630, 249, 18, 4m },
                    { 632, 250, 22, 2m },
                    { 662, 260, 12, 2m },
                    { 661, 259, 12, 2m },
                    { 660, 259, 33, 1m },
                    { 659, 259, 21, 4m },
                    { 658, 258, 33, 3m },
                    { 657, 258, 22, 3m },
                    { 656, 258, 14, 1m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 655, 257, 20, 1m },
                    { 654, 257, 24, 2m },
                    { 653, 257, 3, 2m },
                    { 652, 256, 2, 2m },
                    { 651, 256, 6, 3m },
                    { 650, 256, 13, 2m },
                    { 649, 255, 23, 1m },
                    { 631, 249, 26, 4m },
                    { 648, 255, 19, 4m },
                    { 646, 254, 21, 2m },
                    { 645, 254, 36, 2m },
                    { 644, 254, 23, 2m },
                    { 643, 253, 4, 2m },
                    { 642, 253, 35, 4m },
                    { 641, 253, 34, 4m },
                    { 640, 252, 16, 3m },
                    { 639, 252, 27, 4m },
                    { 638, 252, 32, 4m },
                    { 637, 251, 20, 1m },
                    { 636, 251, 27, 3m },
                    { 635, 251, 5, 2m },
                    { 634, 250, 35, 1m },
                    { 633, 250, 21, 2m },
                    { 647, 255, 23, 3m },
                    { 663, 260, 17, 4m },
                    { 597, 238, 13, 4m },
                    { 595, 237, 28, 4m },
                    { 559, 225, 12, 3m },
                    { 558, 225, 37, 1m },
                    { 557, 225, 7, 1m },
                    { 556, 224, 31, 2m },
                    { 555, 224, 19, 4m },
                    { 554, 224, 30, 3m },
                    { 583, 223, 35, 4m },
                    { 553, 223, 18, 1m },
                    { 552, 223, 28, 1m },
                    { 551, 223, 18, 3m },
                    { 550, 222, 20, 3m },
                    { 549, 222, 36, 3m },
                    { 548, 222, 35, 4m },
                    { 547, 221, 26, 4m },
                    { 560, 226, 30, 3m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 546, 221, 19, 4m },
                    { 679, 25, 28, 1m },
                    { 678, 25, 8, 1m },
                    { 677, 25, 28, 2m },
                    { 676, 24, 30, 1m },
                    { 675, 24, 25, 2m },
                    { 674, 24, 30, 3m },
                    { 673, 23, 8, 2m },
                    { 672, 23, 37, 1m },
                    { 671, 23, 29, 1m },
                    { 670, 22, 6, 1m },
                    { 669, 22, 36, 3m },
                    { 668, 22, 36, 1m },
                    { 667, 21, 21, 1m },
                    { 666, 21, 10, 2m },
                    { 545, 221, 32, 2m },
                    { 596, 238, 9, 3m },
                    { 561, 226, 28, 2m },
                    { 563, 227, 33, 2m },
                    { 594, 237, 12, 2m },
                    { 593, 237, 22, 2m },
                    { 592, 236, 35, 1m },
                    { 591, 236, 23, 4m },
                    { 590, 236, 19, 4m },
                    { 589, 235, 31, 2m },
                    { 588, 235, 35, 3m },
                    { 587, 235, 7, 4m },
                    { 586, 234, 16, 4m },
                    { 585, 234, 6, 2m },
                    { 584, 234, 22, 4m },
                    { 582, 233, 13, 4m },
                    { 581, 233, 4, 2m },
                    { 580, 232, 9, 1m },
                    { 562, 226, 1, 4m },
                    { 579, 232, 25, 3m },
                    { 577, 231, 12, 4m },
                    { 576, 231, 11, 4m },
                    { 575, 231, 36, 3m },
                    { 574, 230, 10, 1m },
                    { 573, 230, 9, 1m },
                    { 572, 230, 28, 3m },
                    { 571, 229, 25, 3m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 570, 229, 32, 3m },
                    { 569, 229, 5, 4m },
                    { 568, 228, 13, 1m },
                    { 567, 228, 15, 1m },
                    { 566, 228, 5, 4m },
                    { 565, 227, 4, 2m },
                    { 564, 227, 20, 2m },
                    { 578, 232, 5, 2m },
                    { 664, 260, 31, 4m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a9e33cc-8094-4766-af0b-48dcc17b774a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d54f0ced-9043-4b59-b55b-d4cf5291a523");

            migrationBuilder.DeleteData(
                table: "MealCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "MealCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ba49c38-f88b-4593-bb80-4f07175c64d7", "d96b4597-2603-439b-afce-d1a49e10c221", "User", null },
                    { "d85308da-f3c2-49e6-a5ac-b491a017cb77", "16716513-1fb7-4c0f-ba5a-3da904350729", "Administrator", null }
                });

            migrationBuilder.UpdateData(
                table: "MealCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Breakfast/Dinner");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 6,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 7,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 8,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 9,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 10,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 101,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 102,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 103,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 104,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 105,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 106,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 107,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 108,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 109,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 110,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 111,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 112,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 113,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 114,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 115,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 116,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 117,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 118,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 119,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 120,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 121,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 122,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 123,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 124,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 125,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 126,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 127,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 128,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 129,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 130,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 131,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 132,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 133,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 134,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 135,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 136,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 137,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 138,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 139,
                column: "MealCategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 140,
                column: "MealCategoryId",
                value: 1);
        }
    }
}
