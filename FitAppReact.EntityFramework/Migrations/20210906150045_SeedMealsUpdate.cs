//Program powstał na Wydziale Informatyki Politechniki Białostockiej

using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAppReact.EntityFramework.Migrations
{
    public partial class SeedMealsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Description", "MealCategoryId", "Name", "Recipe" },
                values: new object[,]
                {
                    { 61, "Description of Breakfast 61", 1, "Breakfast 61", "Recipe of Breakfast 61" },
                    { 163, "Description of Lunch 163", 2, "Lunch 163", "Recipe of Lunch 163" },
                    { 164, "Description of Lunch 164", 2, "Lunch 164", "Recipe of Lunch 164" },
                    { 165, "Description of Lunch 165", 2, "Lunch 165", "Recipe of Lunch 165" },
                    { 166, "Description of Lunch 166", 2, "Lunch 166", "Recipe of Lunch 166" },
                    { 167, "Description of Lunch 167", 2, "Lunch 167", "Recipe of Lunch 167" },
                    { 168, "Description of Lunch 168", 2, "Lunch 168", "Recipe of Lunch 168" },
                    { 169, "Description of Lunch 169", 2, "Lunch 169", "Recipe of Lunch 169" },
                    { 162, "Description of Lunch 162", 2, "Lunch 162", "Recipe of Lunch 162" },
                    { 170, "Description of Lunch 170", 2, "Lunch 170", "Recipe of Lunch 170" },
                    { 172, "Description of Lunch 172", 2, "Lunch 172", "Recipe of Lunch 172" },
                    { 173, "Description of Lunch 173", 2, "Lunch 173", "Recipe of Lunch 173" },
                    { 174, "Description of Lunch 174", 2, "Lunch 174", "Recipe of Lunch 174" },
                    { 175, "Description of Lunch 175", 2, "Lunch 175", "Recipe of Lunch 175" },
                    { 176, "Description of Lunch 176", 2, "Lunch 176", "Recipe of Lunch 176" },
                    { 177, "Description of Lunch 177", 2, "Lunch 177", "Recipe of Lunch 177" },
                    { 178, "Description of Lunch 178", 2, "Lunch 178", "Recipe of Lunch 178" },
                    { 171, "Description of Lunch 171", 2, "Lunch 171", "Recipe of Lunch 171" },
                    { 179, "Description of Lunch 179", 2, "Lunch 179", "Recipe of Lunch 179" },
                    { 161, "Description of Lunch 161", 2, "Lunch 161", "Recipe of Lunch 161" },
                    { 159, "Description of Lunch 159", 2, "Lunch 159", "Recipe of Lunch 159" },
                    { 143, "Description of Lunch 143", 2, "Lunch 143", "Recipe of Lunch 143" },
                    { 144, "Description of Lunch 144", 2, "Lunch 144", "Recipe of Lunch 144" },
                    { 145, "Description of Lunch 145", 2, "Lunch 145", "Recipe of Lunch 145" },
                    { 146, "Description of Lunch 146", 2, "Lunch 146", "Recipe of Lunch 146" },
                    { 147, "Description of Lunch 147", 2, "Lunch 147", "Recipe of Lunch 147" },
                    { 148, "Description of Lunch 148", 2, "Lunch 148", "Recipe of Lunch 148" },
                    { 149, "Description of Lunch 149", 2, "Lunch 149", "Recipe of Lunch 149" },
                    { 160, "Description of Lunch 160", 2, "Lunch 160", "Recipe of Lunch 160" },
                    { 150, "Description of Lunch 150", 2, "Lunch 150", "Recipe of Lunch 150" },
                    { 152, "Description of Lunch 152", 2, "Lunch 152", "Recipe of Lunch 152" },
                    { 153, "Description of Lunch 153", 2, "Lunch 153", "Recipe of Lunch 153" },
                    { 154, "Description of Lunch 154", 2, "Lunch 154", "Recipe of Lunch 154" },
                    { 155, "Description of Lunch 155", 2, "Lunch 155", "Recipe of Lunch 155" },
                    { 156, "Description of Lunch 156", 2, "Lunch 156", "Recipe of Lunch 156" },
                    { 157, "Description of Lunch 157", 2, "Lunch 157", "Recipe of Lunch 157" },
                    { 158, "Description of Lunch 158", 2, "Lunch 158", "Recipe of Lunch 158" },
                    { 151, "Description of Lunch 151", 2, "Lunch 151", "Recipe of Lunch 151" },
                    { 142, "Description of Lunch 142", 2, "Lunch 142", "Recipe of Lunch 142" },
                    { 180, "Description of Lunch 180", 2, "Lunch 180", "Recipe of Lunch 180" },
                    { 182, "Description of Snack 182", 3, "Snack 182", "Recipe of Snack 182" },
                    { 203, "Description of Snack 203", 3, "Snack 203", "Recipe of Snack 203" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Description", "MealCategoryId", "Name", "Recipe" },
                values: new object[,]
                {
                    { 204, "Description of Snack 204", 3, "Snack 204", "Recipe of Snack 204" },
                    { 205, "Description of Snack 205", 3, "Snack 205", "Recipe of Snack 205" },
                    { 206, "Description of Snack 206", 3, "Snack 206", "Recipe of Snack 206" },
                    { 207, "Description of Snack 207", 3, "Snack 207", "Recipe of Snack 207" },
                    { 208, "Description of Snack 208", 3, "Snack 208", "Recipe of Snack 208" },
                    { 209, "Description of Snack 209", 3, "Snack 209", "Recipe of Snack 209" },
                    { 202, "Description of Snack 202", 3, "Snack 202", "Recipe of Snack 202" },
                    { 210, "Description of Snack 210", 3, "Snack 210", "Recipe of Snack 210" },
                    { 212, "Description of Snack 212", 3, "Snack 212", "Recipe of Snack 212" },
                    { 213, "Description of Snack 213", 3, "Snack 213", "Recipe of Snack 213" },
                    { 214, "Description of Snack 214", 3, "Snack 214", "Recipe of Snack 214" },
                    { 215, "Description of Snack 215", 3, "Snack 215", "Recipe of Snack 215" },
                    { 216, "Description of Snack 216", 3, "Snack 216", "Recipe of Snack 216" },
                    { 217, "Description of Snack 217", 3, "Snack 217", "Recipe of Snack 217" },
                    { 218, "Description of Snack 218", 3, "Snack 218", "Recipe of Snack 218" },
                    { 211, "Description of Snack 211", 3, "Snack 211", "Recipe of Snack 211" },
                    { 181, "Description of Snack 181", 3, "Snack 181", "Recipe of Snack 181" },
                    { 201, "Description of Snack 201", 3, "Snack 201", "Recipe of Snack 201" },
                    { 199, "Description of Snack 199", 3, "Snack 199", "Recipe of Snack 199" },
                    { 183, "Description of Snack 183", 3, "Snack 183", "Recipe of Snack 183" },
                    { 184, "Description of Snack 184", 3, "Snack 184", "Recipe of Snack 184" },
                    { 185, "Description of Snack 185", 3, "Snack 185", "Recipe of Snack 185" },
                    { 186, "Description of Snack 186", 3, "Snack 186", "Recipe of Snack 186" },
                    { 187, "Description of Snack 187", 3, "Snack 187", "Recipe of Snack 187" },
                    { 188, "Description of Snack 188", 3, "Snack 188", "Recipe of Snack 188" },
                    { 189, "Description of Snack 189", 3, "Snack 189", "Recipe of Snack 189" },
                    { 200, "Description of Snack 200", 3, "Snack 200", "Recipe of Snack 200" },
                    { 190, "Description of Snack 190", 3, "Snack 190", "Recipe of Snack 190" },
                    { 192, "Description of Snack 192", 3, "Snack 192", "Recipe of Snack 192" },
                    { 193, "Description of Snack 193", 3, "Snack 193", "Recipe of Snack 193" },
                    { 194, "Description of Snack 194", 3, "Snack 194", "Recipe of Snack 194" },
                    { 195, "Description of Snack 195", 3, "Snack 195", "Recipe of Snack 195" },
                    { 196, "Description of Snack 196", 3, "Snack 196", "Recipe of Snack 196" },
                    { 197, "Description of Snack 197", 3, "Snack 197", "Recipe of Snack 197" },
                    { 198, "Description of Snack 198", 3, "Snack 198", "Recipe of Snack 198" },
                    { 191, "Description of Snack 191", 3, "Snack 191", "Recipe of Snack 191" },
                    { 141, "Description of Lunch 141", 2, "Lunch 141", "Recipe of Lunch 141" },
                    { 140, "Description of Dinner 140", 1, "Dinner 140", "Recipe of Dinner 140" },
                    { 139, "Description of Dinner 139", 1, "Dinner 139", "Recipe of Dinner 139" },
                    { 82, "Description of Breakfast 82", 1, "Breakfast 82", "Recipe of Breakfast 82" },
                    { 83, "Description of Breakfast 83", 1, "Breakfast 83", "Recipe of Breakfast 83" },
                    { 84, "Description of Breakfast 84", 1, "Breakfast 84", "Recipe of Breakfast 84" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Description", "MealCategoryId", "Name", "Recipe" },
                values: new object[,]
                {
                    { 85, "Description of Breakfast 85", 1, "Breakfast 85", "Recipe of Breakfast 85" },
                    { 86, "Description of Breakfast 86", 1, "Breakfast 86", "Recipe of Breakfast 86" },
                    { 87, "Description of Breakfast 87", 1, "Breakfast 87", "Recipe of Breakfast 87" },
                    { 88, "Description of Breakfast 88", 1, "Breakfast 88", "Recipe of Breakfast 88" },
                    { 81, "Description of Breakfast 81", 1, "Breakfast 81", "Recipe of Breakfast 81" },
                    { 89, "Description of Breakfast 89", 1, "Breakfast 89", "Recipe of Breakfast 89" },
                    { 91, "Description of Breakfast 91", 1, "Breakfast 91", "Recipe of Breakfast 91" },
                    { 92, "Description of Breakfast 92", 1, "Breakfast 92", "Recipe of Breakfast 92" },
                    { 93, "Description of Breakfast 93", 1, "Breakfast 93", "Recipe of Breakfast 93" },
                    { 94, "Description of Breakfast 94", 1, "Breakfast 94", "Recipe of Breakfast 94" },
                    { 95, "Description of Breakfast 95", 1, "Breakfast 95", "Recipe of Breakfast 95" },
                    { 96, "Description of Breakfast 96", 1, "Breakfast 96", "Recipe of Breakfast 96" },
                    { 97, "Description of Breakfast 97", 1, "Breakfast 97", "Recipe of Breakfast 97" },
                    { 90, "Description of Breakfast 90", 1, "Breakfast 90", "Recipe of Breakfast 90" },
                    { 98, "Description of Breakfast 98", 1, "Breakfast 98", "Recipe of Breakfast 98" },
                    { 80, "Description of Breakfast 80", 1, "Breakfast 80", "Recipe of Breakfast 80" },
                    { 78, "Description of Breakfast 78", 1, "Breakfast 78", "Recipe of Breakfast 78" },
                    { 62, "Description of Breakfast 62", 1, "Breakfast 62", "Recipe of Breakfast 62" },
                    { 63, "Description of Breakfast 63", 1, "Breakfast 63", "Recipe of Breakfast 63" },
                    { 64, "Description of Breakfast 64", 1, "Breakfast 64", "Recipe of Breakfast 64" },
                    { 65, "Description of Breakfast 65", 1, "Breakfast 65", "Recipe of Breakfast 65" },
                    { 66, "Description of Breakfast 66", 1, "Breakfast 66", "Recipe of Breakfast 66" },
                    { 67, "Description of Breakfast 67", 1, "Breakfast 67", "Recipe of Breakfast 67" },
                    { 68, "Description of Breakfast 68", 1, "Breakfast 68", "Recipe of Breakfast 68" },
                    { 79, "Description of Breakfast 79", 1, "Breakfast 79", "Recipe of Breakfast 79" },
                    { 69, "Description of Breakfast 69", 1, "Breakfast 69", "Recipe of Breakfast 69" },
                    { 71, "Description of Breakfast 71", 1, "Breakfast 71", "Recipe of Breakfast 71" },
                    { 72, "Description of Breakfast 72", 1, "Breakfast 72", "Recipe of Breakfast 72" },
                    { 73, "Description of Breakfast 73", 1, "Breakfast 73", "Recipe of Breakfast 73" },
                    { 74, "Description of Breakfast 74", 1, "Breakfast 74", "Recipe of Breakfast 74" },
                    { 75, "Description of Breakfast 75", 1, "Breakfast 75", "Recipe of Breakfast 75" },
                    { 76, "Description of Breakfast 76", 1, "Breakfast 76", "Recipe of Breakfast 76" },
                    { 77, "Description of Breakfast 77", 1, "Breakfast 77", "Recipe of Breakfast 77" },
                    { 70, "Description of Breakfast 70", 1, "Breakfast 70", "Recipe of Breakfast 70" },
                    { 99, "Description of Breakfast 99", 1, "Breakfast 99", "Recipe of Breakfast 99" },
                    { 100, "Description of Breakfast 100", 1, "Breakfast 100", "Recipe of Breakfast 100" },
                    { 101, "Description of Dinner 101", 1, "Dinner 101", "Recipe of Dinner 101" },
                    { 123, "Description of Dinner 123", 1, "Dinner 123", "Recipe of Dinner 123" },
                    { 124, "Description of Dinner 124", 1, "Dinner 124", "Recipe of Dinner 124" },
                    { 125, "Description of Dinner 125", 1, "Dinner 125", "Recipe of Dinner 125" },
                    { 126, "Description of Dinner 126", 1, "Dinner 126", "Recipe of Dinner 126" },
                    { 127, "Description of Dinner 127", 1, "Dinner 127", "Recipe of Dinner 127" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Description", "MealCategoryId", "Name", "Recipe" },
                values: new object[,]
                {
                    { 128, "Description of Dinner 128", 1, "Dinner 128", "Recipe of Dinner 128" },
                    { 129, "Description of Dinner 129", 1, "Dinner 129", "Recipe of Dinner 129" },
                    { 122, "Description of Dinner 122", 1, "Dinner 122", "Recipe of Dinner 122" },
                    { 130, "Description of Dinner 130", 1, "Dinner 130", "Recipe of Dinner 130" },
                    { 132, "Description of Dinner 132", 1, "Dinner 132", "Recipe of Dinner 132" },
                    { 133, "Description of Dinner 133", 1, "Dinner 133", "Recipe of Dinner 133" },
                    { 134, "Description of Dinner 134", 1, "Dinner 134", "Recipe of Dinner 134" },
                    { 135, "Description of Dinner 135", 1, "Dinner 135", "Recipe of Dinner 135" },
                    { 136, "Description of Dinner 136", 1, "Dinner 136", "Recipe of Dinner 136" },
                    { 137, "Description of Dinner 137", 1, "Dinner 137", "Recipe of Dinner 137" },
                    { 138, "Description of Dinner 138", 1, "Dinner 138", "Recipe of Dinner 138" },
                    { 131, "Description of Dinner 131", 1, "Dinner 131", "Recipe of Dinner 131" },
                    { 121, "Description of Dinner 121", 1, "Dinner 121", "Recipe of Dinner 121" },
                    { 120, "Description of Dinner 120", 1, "Dinner 120", "Recipe of Dinner 120" },
                    { 119, "Description of Dinner 119", 1, "Dinner 119", "Recipe of Dinner 119" },
                    { 102, "Description of Dinner 102", 1, "Dinner 102", "Recipe of Dinner 102" },
                    { 103, "Description of Dinner 103", 1, "Dinner 103", "Recipe of Dinner 103" },
                    { 104, "Description of Dinner 104", 1, "Dinner 104", "Recipe of Dinner 104" },
                    { 105, "Description of Dinner 105", 1, "Dinner 105", "Recipe of Dinner 105" },
                    { 106, "Description of Dinner 106", 1, "Dinner 106", "Recipe of Dinner 106" },
                    { 107, "Description of Dinner 107", 1, "Dinner 107", "Recipe of Dinner 107" },
                    { 108, "Description of Dinner 108", 1, "Dinner 108", "Recipe of Dinner 108" },
                    { 109, "Description of Dinner 109", 1, "Dinner 109", "Recipe of Dinner 109" },
                    { 110, "Description of Dinner 110", 1, "Dinner 110", "Recipe of Dinner 110" },
                    { 111, "Description of Dinner 111", 1, "Dinner 111", "Recipe of Dinner 111" },
                    { 112, "Description of Dinner 112", 1, "Dinner 112", "Recipe of Dinner 112" },
                    { 113, "Description of Dinner 113", 1, "Dinner 113", "Recipe of Dinner 113" },
                    { 114, "Description of Dinner 114", 1, "Dinner 114", "Recipe of Dinner 114" },
                    { 115, "Description of Dinner 115", 1, "Dinner 115", "Recipe of Dinner 115" },
                    { 116, "Description of Dinner 116", 1, "Dinner 116", "Recipe of Dinner 116" },
                    { 117, "Description of Dinner 117", 1, "Dinner 117", "Recipe of Dinner 117" },
                    { 118, "Description of Dinner 118", 1, "Dinner 118", "Recipe of Dinner 118" },
                    { 219, "Description of Snack 219", 3, "Snack 219", "Recipe of Snack 219" },
                    { 220, "Description of Snack 220", 3, "Snack 220", "Recipe of Snack 220" }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 62, 61, 23, 3m },
                    { 391, 170, 26, 3m },
                    { 390, 169, 12, 1m },
                    { 389, 169, 31, 1m },
                    { 388, 169, 26, 3m },
                    { 387, 168, 21, 1m },
                    { 386, 168, 16, 3m },
                    { 385, 168, 21, 2m },
                    { 384, 167, 5, 2m },
                    { 383, 167, 23, 1m },
                    { 382, 167, 3, 3m },
                    { 381, 166, 19, 2m },
                    { 380, 166, 35, 2m },
                    { 392, 170, 9, 3m },
                    { 379, 166, 32, 2m },
                    { 377, 165, 3, 1m },
                    { 376, 165, 33, 4m },
                    { 375, 164, 34, 3m },
                    { 374, 164, 34, 1m },
                    { 373, 164, 16, 1m },
                    { 372, 163, 8, 2m },
                    { 371, 163, 7, 4m },
                    { 370, 163, 18, 3m },
                    { 369, 162, 17, 3m },
                    { 368, 162, 29, 3m },
                    { 367, 162, 9, 3m },
                    { 366, 161, 12, 3m },
                    { 378, 165, 31, 2m },
                    { 365, 161, 8, 2m },
                    { 393, 170, 37, 3m },
                    { 395, 171, 5, 2m },
                    { 421, 180, 19, 2m },
                    { 420, 179, 19, 3m },
                    { 419, 179, 29, 3m },
                    { 418, 179, 14, 1m },
                    { 417, 178, 6, 1m },
                    { 416, 178, 8, 2m },
                    { 415, 178, 2, 1m },
                    { 414, 177, 22, 2m },
                    { 413, 177, 23, 2m },
                    { 412, 177, 1, 2m },
                    { 411, 176, 35, 1m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 410, 176, 17, 2m },
                    { 394, 171, 7, 1m },
                    { 409, 176, 33, 1m },
                    { 407, 175, 6, 3m },
                    { 406, 175, 20, 4m },
                    { 405, 174, 2, 2m },
                    { 404, 174, 1, 2m },
                    { 403, 174, 30, 1m },
                    { 402, 173, 3, 1m },
                    { 401, 173, 31, 4m },
                    { 400, 173, 2, 2m },
                    { 399, 172, 28, 2m },
                    { 398, 172, 12, 4m },
                    { 397, 172, 33, 2m },
                    { 396, 171, 7, 4m },
                    { 408, 175, 15, 3m },
                    { 422, 180, 10, 4m },
                    { 364, 161, 22, 1m },
                    { 362, 160, 2, 2m },
                    { 331, 150, 20, 3m },
                    { 330, 149, 31, 1m },
                    { 329, 149, 34, 4m },
                    { 328, 149, 24, 3m },
                    { 327, 148, 33, 4m },
                    { 326, 148, 34, 2m },
                    { 325, 148, 21, 2m },
                    { 324, 147, 28, 3m },
                    { 323, 147, 12, 2m },
                    { 322, 147, 19, 2m },
                    { 321, 146, 3, 2m },
                    { 320, 146, 24, 1m },
                    { 332, 150, 15, 4m },
                    { 319, 146, 4, 4m },
                    { 317, 145, 20, 2m },
                    { 316, 145, 26, 3m },
                    { 315, 144, 30, 3m },
                    { 314, 144, 21, 3m },
                    { 313, 144, 29, 3m },
                    { 312, 143, 20, 2m },
                    { 311, 143, 36, 3m },
                    { 310, 143, 1, 2m },
                    { 309, 142, 26, 2m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 308, 142, 35, 3m },
                    { 307, 142, 35, 1m },
                    { 306, 141, 25, 2m },
                    { 318, 145, 36, 1m },
                    { 363, 160, 28, 3m },
                    { 333, 150, 2, 3m },
                    { 335, 151, 32, 3m },
                    { 361, 160, 20, 1m },
                    { 360, 159, 31, 3m },
                    { 359, 159, 30, 1m },
                    { 358, 159, 27, 4m },
                    { 357, 158, 4, 4m },
                    { 356, 158, 10, 2m },
                    { 355, 158, 23, 3m },
                    { 354, 157, 3, 4m },
                    { 353, 157, 21, 3m },
                    { 352, 157, 31, 4m },
                    { 351, 156, 37, 2m },
                    { 350, 156, 20, 2m },
                    { 334, 151, 27, 4m },
                    { 349, 156, 28, 1m },
                    { 347, 155, 5, 4m },
                    { 346, 155, 13, 3m },
                    { 345, 154, 24, 1m },
                    { 344, 154, 8, 1m },
                    { 343, 154, 7, 1m },
                    { 342, 153, 34, 2m },
                    { 341, 153, 18, 2m },
                    { 340, 153, 35, 3m },
                    { 339, 152, 11, 4m },
                    { 338, 152, 3, 4m },
                    { 337, 152, 9, 4m },
                    { 336, 151, 3, 3m },
                    { 348, 155, 20, 1m },
                    { 305, 141, 1, 1m },
                    { 423, 180, 25, 2m },
                    { 426, 181, 19, 4m },
                    { 512, 210, 22, 2m },
                    { 511, 209, 26, 4m },
                    { 510, 209, 18, 4m },
                    { 509, 209, 9, 4m },
                    { 508, 208, 25, 2m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 507, 208, 33, 1m },
                    { 506, 208, 17, 2m },
                    { 505, 207, 37, 3m },
                    { 504, 207, 14, 4m },
                    { 503, 207, 9, 3m },
                    { 502, 206, 8, 2m },
                    { 501, 206, 25, 4m },
                    { 513, 210, 21, 2m },
                    { 500, 206, 15, 2m },
                    { 498, 205, 1, 2m },
                    { 497, 205, 30, 4m },
                    { 496, 204, 6, 2m },
                    { 495, 204, 16, 1m },
                    { 494, 204, 30, 1m },
                    { 493, 203, 2, 2m },
                    { 492, 203, 29, 2m },
                    { 491, 203, 10, 2m },
                    { 490, 202, 36, 4m },
                    { 489, 202, 21, 4m },
                    { 488, 202, 36, 4m },
                    { 487, 201, 9, 4m },
                    { 499, 205, 5, 3m },
                    { 486, 201, 18, 3m },
                    { 514, 210, 35, 1m },
                    { 516, 211, 27, 3m },
                    { 542, 220, 12, 2m },
                    { 541, 219, 12, 2m },
                    { 540, 219, 33, 1m },
                    { 539, 219, 21, 4m },
                    { 538, 218, 33, 3m },
                    { 537, 218, 22, 3m },
                    { 536, 218, 14, 1m },
                    { 535, 217, 20, 1m },
                    { 534, 217, 24, 2m },
                    { 533, 217, 3, 2m },
                    { 532, 216, 2, 2m },
                    { 531, 216, 6, 3m },
                    { 515, 211, 5, 2m },
                    { 530, 216, 13, 2m },
                    { 528, 215, 19, 4m },
                    { 527, 215, 23, 3m },
                    { 526, 214, 21, 2m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 525, 214, 36, 2m },
                    { 524, 214, 23, 2m },
                    { 523, 213, 4, 2m },
                    { 522, 213, 35, 4m },
                    { 521, 213, 34, 4m },
                    { 520, 212, 16, 3m },
                    { 519, 212, 27, 4m },
                    { 518, 212, 32, 4m },
                    { 517, 211, 20, 1m },
                    { 529, 215, 23, 1m },
                    { 425, 181, 32, 2m },
                    { 485, 201, 22, 3m },
                    { 483, 200, 20, 3m },
                    { 452, 190, 28, 3m },
                    { 451, 189, 25, 3m },
                    { 450, 189, 32, 3m },
                    { 449, 189, 5, 4m },
                    { 448, 188, 13, 1m },
                    { 447, 188, 15, 1m },
                    { 446, 188, 5, 4m },
                    { 445, 187, 4, 2m },
                    { 444, 187, 20, 2m },
                    { 443, 187, 33, 2m },
                    { 442, 186, 1, 4m },
                    { 441, 186, 28, 2m },
                    { 453, 190, 9, 1m },
                    { 440, 186, 30, 3m },
                    { 438, 185, 37, 1m },
                    { 437, 185, 7, 1m },
                    { 436, 184, 31, 2m },
                    { 435, 184, 19, 4m },
                    { 434, 184, 30, 3m },
                    { 433, 183, 18, 1m },
                    { 432, 183, 28, 1m },
                    { 431, 183, 18, 3m },
                    { 430, 182, 20, 3m },
                    { 429, 182, 36, 3m },
                    { 428, 182, 35, 4m },
                    { 427, 181, 26, 4m },
                    { 439, 185, 12, 3m },
                    { 484, 200, 30, 4m },
                    { 454, 190, 10, 1m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 456, 191, 11, 4m },
                    { 482, 200, 4, 2m },
                    { 481, 199, 31, 3m },
                    { 480, 199, 18, 2m },
                    { 479, 199, 12, 4m },
                    { 478, 198, 17, 2m },
                    { 477, 198, 13, 4m },
                    { 476, 198, 9, 3m },
                    { 475, 197, 28, 4m },
                    { 474, 197, 12, 2m },
                    { 473, 197, 22, 2m },
                    { 472, 196, 35, 1m },
                    { 471, 196, 23, 4m },
                    { 455, 191, 36, 3m },
                    { 470, 196, 19, 4m },
                    { 468, 195, 35, 3m },
                    { 467, 195, 7, 4m },
                    { 466, 194, 16, 4m },
                    { 465, 194, 6, 2m },
                    { 464, 194, 22, 4m },
                    { 463, 193, 35, 4m },
                    { 462, 193, 13, 4m },
                    { 461, 193, 4, 2m },
                    { 460, 192, 9, 1m },
                    { 459, 192, 25, 3m },
                    { 458, 192, 5, 2m },
                    { 457, 191, 12, 4m },
                    { 469, 195, 31, 2m },
                    { 304, 141, 23, 3m },
                    { 302, 140, 28, 3m },
                    { 301, 140, 25, 3m },
                    { 148, 89, 5, 1m },
                    { 147, 89, 34, 2m },
                    { 146, 89, 13, 3m },
                    { 145, 88, 23, 1m },
                    { 144, 88, 9, 3m },
                    { 143, 88, 23, 3m },
                    { 142, 87, 26, 4m },
                    { 141, 87, 21, 2m },
                    { 140, 87, 6, 2m },
                    { 139, 86, 33, 1m },
                    { 138, 86, 9, 3m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 137, 86, 31, 3m },
                    { 149, 90, 11, 2m },
                    { 136, 85, 31, 2m },
                    { 134, 85, 15, 1m },
                    { 133, 84, 30, 4m },
                    { 132, 84, 23, 3m },
                    { 131, 84, 21, 4m },
                    { 130, 83, 24, 3m },
                    { 129, 83, 36, 3m },
                    { 128, 83, 27, 1m },
                    { 127, 82, 18, 1m },
                    { 126, 82, 36, 1m },
                    { 125, 82, 15, 3m },
                    { 124, 81, 19, 1m },
                    { 123, 81, 10, 2m },
                    { 135, 85, 19, 4m },
                    { 122, 81, 34, 2m },
                    { 150, 90, 21, 2m },
                    { 152, 91, 16, 4m },
                    { 178, 99, 28, 2m },
                    { 177, 99, 1, 3m },
                    { 176, 99, 22, 2m },
                    { 175, 98, 18, 3m },
                    { 174, 98, 18, 1m },
                    { 173, 98, 1, 2m },
                    { 172, 97, 23, 2m },
                    { 171, 97, 9, 3m },
                    { 170, 97, 4, 3m },
                    { 169, 96, 8, 4m },
                    { 168, 96, 28, 4m },
                    { 167, 96, 36, 4m },
                    { 151, 90, 15, 3m },
                    { 166, 95, 21, 4m },
                    { 164, 95, 21, 2m },
                    { 163, 94, 14, 1m },
                    { 162, 94, 11, 2m },
                    { 161, 94, 20, 2m },
                    { 160, 93, 18, 2m },
                    { 159, 93, 3, 2m },
                    { 158, 93, 25, 1m },
                    { 157, 92, 7, 2m },
                    { 156, 92, 23, 3m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 155, 92, 10, 1m },
                    { 154, 91, 26, 2m },
                    { 153, 91, 18, 4m },
                    { 165, 95, 19, 1m },
                    { 179, 100, 23, 3m },
                    { 121, 80, 21, 3m },
                    { 119, 80, 33, 4m },
                    { 88, 69, 13, 4m },
                    { 87, 69, 21, 1m },
                    { 86, 69, 4, 1m },
                    { 85, 68, 26, 2m },
                    { 84, 68, 32, 4m },
                    { 83, 68, 9, 4m },
                    { 82, 67, 20, 1m },
                    { 81, 67, 30, 3m },
                    { 80, 67, 20, 2m },
                    { 79, 66, 28, 1m },
                    { 78, 66, 12, 4m },
                    { 77, 66, 19, 4m },
                    { 89, 70, 31, 1m },
                    { 76, 65, 26, 4m },
                    { 74, 65, 14, 4m },
                    { 73, 64, 27, 1m },
                    { 72, 64, 5, 3m },
                    { 71, 64, 31, 4m },
                    { 70, 63, 12, 3m },
                    { 69, 63, 4, 2m },
                    { 68, 63, 13, 3m },
                    { 67, 62, 20, 3m },
                    { 66, 62, 15, 4m },
                    { 65, 62, 25, 3m },
                    { 64, 61, 32, 2m },
                    { 63, 61, 12, 4m },
                    { 75, 65, 25, 4m },
                    { 120, 80, 12, 1m },
                    { 90, 70, 12, 1m },
                    { 92, 71, 23, 3m },
                    { 118, 79, 7, 4m },
                    { 117, 79, 4, 2m },
                    { 116, 79, 12, 2m },
                    { 115, 78, 7, 2m },
                    { 114, 78, 36, 4m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 113, 78, 16, 1m },
                    { 112, 77, 1, 4m },
                    { 111, 77, 16, 4m },
                    { 110, 77, 12, 1m },
                    { 109, 76, 17, 1m },
                    { 108, 76, 22, 4m },
                    { 107, 76, 10, 3m },
                    { 91, 70, 24, 4m },
                    { 106, 75, 11, 4m },
                    { 104, 75, 28, 1m },
                    { 103, 74, 17, 2m },
                    { 102, 74, 27, 4m },
                    { 101, 74, 29, 2m },
                    { 100, 73, 3, 4m },
                    { 99, 73, 10, 4m },
                    { 98, 73, 24, 4m },
                    { 97, 72, 32, 4m },
                    { 96, 72, 28, 1m },
                    { 95, 72, 6, 1m },
                    { 94, 71, 28, 3m },
                    { 93, 71, 14, 2m },
                    { 105, 75, 26, 3m },
                    { 180, 100, 30, 3m },
                    { 181, 100, 29, 2m },
                    { 183, 101, 4, 4m },
                    { 270, 130, 13, 2m },
                    { 269, 129, 36, 4m },
                    { 268, 129, 34, 4m },
                    { 267, 129, 4, 2m },
                    { 266, 128, 33, 4m },
                    { 265, 128, 16, 4m },
                    { 264, 128, 22, 2m },
                    { 263, 127, 10, 2m },
                    { 262, 127, 30, 3m },
                    { 261, 127, 27, 1m },
                    { 260, 126, 8, 3m },
                    { 259, 126, 3, 2m },
                    { 271, 130, 19, 1m },
                    { 258, 126, 37, 3m },
                    { 256, 125, 5, 4m },
                    { 255, 125, 32, 4m },
                    { 254, 124, 7, 3m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 253, 124, 32, 3m },
                    { 252, 124, 32, 1m },
                    { 251, 123, 34, 1m },
                    { 250, 123, 17, 2m },
                    { 249, 123, 23, 3m },
                    { 248, 122, 32, 3m },
                    { 247, 122, 35, 3m },
                    { 246, 122, 2, 1m },
                    { 245, 121, 8, 4m },
                    { 257, 125, 37, 4m },
                    { 244, 121, 24, 2m },
                    { 272, 130, 27, 4m },
                    { 274, 131, 33, 2m },
                    { 300, 140, 2, 4m },
                    { 299, 139, 35, 1m },
                    { 298, 139, 37, 2m },
                    { 297, 139, 36, 4m },
                    { 296, 138, 3, 1m },
                    { 295, 138, 30, 1m },
                    { 294, 138, 18, 2m },
                    { 293, 137, 31, 1m },
                    { 292, 137, 14, 4m },
                    { 291, 137, 6, 4m },
                    { 290, 136, 6, 2m },
                    { 289, 136, 33, 4m },
                    { 273, 131, 24, 2m },
                    { 288, 136, 19, 3m },
                    { 286, 135, 4, 2m },
                    { 285, 135, 25, 4m },
                    { 284, 134, 33, 1m },
                    { 283, 134, 21, 2m },
                    { 282, 134, 35, 3m },
                    { 281, 133, 10, 3m },
                    { 280, 133, 1, 2m },
                    { 279, 133, 6, 3m },
                    { 278, 132, 35, 1m },
                    { 277, 132, 11, 1m },
                    { 276, 132, 23, 4m },
                    { 275, 131, 33, 1m },
                    { 287, 135, 5, 3m },
                    { 243, 121, 32, 4m },
                    { 242, 120, 18, 2m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 241, 120, 7, 4m },
                    { 209, 109, 27, 3m },
                    { 208, 109, 5, 1m },
                    { 207, 109, 20, 4m },
                    { 206, 108, 3, 3m },
                    { 205, 108, 35, 2m },
                    { 204, 108, 25, 1m },
                    { 203, 107, 33, 3m },
                    { 202, 107, 4, 3m },
                    { 201, 107, 30, 1m },
                    { 200, 106, 18, 2m },
                    { 199, 106, 29, 1m },
                    { 198, 106, 3, 3m },
                    { 210, 110, 34, 3m },
                    { 197, 105, 37, 4m },
                    { 195, 105, 6, 3m },
                    { 194, 104, 33, 1m },
                    { 193, 104, 34, 1m },
                    { 192, 104, 14, 4m },
                    { 191, 103, 23, 1m },
                    { 190, 103, 33, 4m },
                    { 189, 103, 31, 1m },
                    { 188, 102, 32, 3m },
                    { 187, 102, 32, 3m },
                    { 186, 102, 36, 4m },
                    { 185, 101, 5, 1m },
                    { 184, 101, 6, 3m },
                    { 196, 105, 13, 4m },
                    { 211, 110, 15, 3m },
                    { 212, 110, 12, 4m },
                    { 213, 111, 7, 4m },
                    { 240, 120, 30, 2m },
                    { 239, 119, 36, 1m },
                    { 238, 119, 7, 3m },
                    { 237, 119, 24, 3m },
                    { 236, 118, 16, 4m },
                    { 235, 118, 20, 2m },
                    { 234, 118, 37, 4m },
                    { 233, 117, 36, 2m },
                    { 232, 117, 9, 2m },
                    { 231, 117, 9, 3m },
                    { 230, 116, 32, 1m }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "Id", "MealId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 229, 116, 23, 4m },
                    { 228, 116, 17, 1m },
                    { 227, 115, 3, 2m },
                    { 226, 115, 17, 3m },
                    { 225, 115, 12, 3m },
                    { 224, 114, 23, 4m },
                    { 223, 114, 32, 3m },
                    { 222, 114, 16, 1m },
                    { 221, 113, 13, 2m },
                    { 220, 113, 13, 1m },
                    { 219, 113, 36, 4m },
                    { 218, 112, 33, 3m },
                    { 217, 112, 6, 2m },
                    { 216, 112, 16, 4m },
                    { 215, 111, 1, 2m },
                    { 214, 111, 29, 2m },
                    { 543, 220, 17, 4m },
                    { 544, 220, 31, 4m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 220);
        }
    }
}
