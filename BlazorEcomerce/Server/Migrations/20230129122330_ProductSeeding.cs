using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcomerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Birds of America (1998) is a collection of short stories by American writer Lorrie Moore. The stories in this collection originally appeared in The New Yorker, Elle, The New York Times, and The Paris Review. The story \"People Like That Are the Only People Here\" won an O. Henry Award in 1998. The book became a New York Times bestseller, a rarity for a short story collection. The book was included in the New York Times Book Review books of the year list in 1998.[1] Winner of the Irish Times international fiction prize. A Village Voice book of the year (1998). Winner of the Salon Book Award.", "https://upload.wikimedia.org/wikipedia/en/9/9b/BeingDead.jpg", 9.99m, "Birds of America" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "The eight stories of this collection (one of which was originally published in Saturday Night; five others were originally published in The New Yorker) deal with Munro's typical themes: secrets, love, betrayal, and the stuff of ordinary lives.", "https://upload.wikimedia.org/wikipedia/en/8/8c/TheLoveOfAGoodWoman.jpg", 5.99m, "The Love of a Good Woman" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Its principal characters are married zoologists Joseph and Celice and their daughter Syl. The story tells of how Joseph and Celice, on a day trip to the dunes where they met as students, are murdered by an opportunistic thief. Their bodies lie undiscovered for several days, during the course of which their estranged daughter is made aware of their disappearance and, eventually, discovery. The novel dwells heavily on the themes of bodily decomposition and filial bereavement.", "https://upload.wikimedia.org/wikipedia/en/9/9b/BeingDead.jpg", 3.99m, "Being Dead" });
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
        }
    }
}
