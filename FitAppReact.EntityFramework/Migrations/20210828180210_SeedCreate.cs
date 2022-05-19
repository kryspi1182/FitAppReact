

using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAppReact.EntityFramework.Migrations
{
    public partial class SeedCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Fat", "Fibre", "Name", "Protein", "Salt", "Sugar" },
                values: new object[,]
                {
                    { 1, 583m, 6m, 52m, 11m, "Almond", 20m, 0m, 3m },
                    { 21, 354m, 66m, 4m, 9m, "Corn", 9m, 0m, 2m },
                    { 22, 225m, 0m, 17m, 0m, "Duck", 18m, 0m, 0m },
                    { 23, 235m, 1m, 20m, 0m, "Eggs", 14m, 0m, 0m },
                    { 24, 247m, 18m, 12m, 2m, "Fish sticks", 15m, 0m, 1m },
                    { 25, 307m, 46m, 11m, 3m, "French fries", 6m, 0m, 0m },
                    { 26, 57m, 14m, 0m, 1m, "Grapes", 1m, 0m, 13m },
                    { 27, 201m, 1m, 13m, 0m, "Ham", 22m, 0m, 1m },
                    { 28, 667m, 11m, 63m, 8m, "Hazelnut", 14m, 0m, 9m },
                    { 29, 308m, 76m, 0m, 0m, "Honey", 0m, 0m, 75m },
                    { 30, 247m, 60m, 0m, 2m, "Jam", 0m, 0m, 59m },
                    { 31, 116m, 1m, 5m, 0m, "Kidneys(pork)", 17m, 0m, 0m },
                    { 32, 48m, 10m, 0m, 1m, "Kiwi", 1m, 0m, 8m },
                    { 33, 11m, 1m, 0m, 1m, "Lettuce", 1m, 0m, 1m },
                    { 34, 132m, 2m, 4m, 0m, "Liver(pork)", 22m, 0m, 2m },
                    { 35, 741m, 3m, 82m, 0m, "Mayonese", 2m, 0m, 3m },
                    { 20, 103m, 0m, 2m, 0m, "Chicken leg", 21m, 0m, 0m },
                    { 36, 62m, 4m, 3m, 0m, "Milk", 4m, 0m, 4m },
                    { 19, 157m, 0m, 4m, 0m, "Chicken breast", 30m, 0m, 0m },
                    { 17, 27m, 5m, 0m, 3m, "Carrot", 1m, 0m, 4m },
                    { 2, 54m, 12m, 0m, 2m, "Apple", 0m, 0m, 12m },
                    { 3, 60m, 12m, 0m, 2m, "Apricot", 1m, 0m, 8m },
                    { 4, 17m, 1m, 0m, 2m, "Aspargus", 2m, 0m, 1m },
                    { 5, 188m, 2m, 18m, 6m, "Avocado", 3m, 0m, 1m },
                    { 6, 86m, 19m, 0m, 2m, "Banana", 1m, 0m, 18m },
                    { 7, 114m, 15m, 1m, 11m, "Beans(white)", 8m, 0m, 0m },
                    { 8, 198m, 1m, 9m, 0m, "Beef", 30m, 0m, 0m },
                    { 9, 58m, 9m, 1m, 5m, "Blackberry", 1m, 0m, 7m },
                    { 10, 75m, 15m, 0m, 7m, "Berry", 1m, 0m, 14m },
                    { 11, 283m, 58m, 2m, 4m, "Bread(white)", 8m, 0m, 2m },
                    { 12, 262m, 45m, 3m, 6m, "Bread(whole wheat)", 10m, 0m, 2m },
                    { 13, 29m, 2m, 0m, 4m, "Broccoli", 3m, 0m, 2m },
                    { 14, 25m, 3m, 0m, 5m, "Brussels", 3m, 0m, 3m },
                    { 15, 375m, 80m, 1m, 2m, "Bulgur groats", 10m, 0m, 2m },
                    { 16, 735m, 1m, 83m, 0m, "Butter", 1m, 0m, 1m },
                    { 18, 20m, 2m, 0m, 2m, "Califlower", 2m, 0m, 2m },
                    { 37, 359m, 80m, 1m, 0m, "Rice", 8m, 0m, 0m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);
        }
    }
}
