using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcomerce.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 1, "Books", "books" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 2, "Movies", "movies" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 3, "Games", "games" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, 1, "Birds of America (1998) is a collection of short stories by American writer Lorrie Moore. The stories in this collection originally appeared in The New Yorker, Elle, The New York Times, and The Paris Review. The story \"People Like That Are the Only People Here\" won an O. Henry Award in 1998. The book became a New York Times bestseller, a rarity for a short story collection. The book was included in the New York Times Book Review books of the year list in 1998.[1] Winner of the Irish Times international fiction prize. A Village Voice book of the year (1998). Winner of the Salon Book Award.", "https://upload.wikimedia.org/wikipedia/en/9/9b/BeingDead.jpg", 9.99m, "Birds of America" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, 1, "The eight stories of this collection (one of which was originally published in Saturday Night; five others were originally published in The New Yorker) deal with Munro's typical themes: secrets, love, betrayal, and the stuff of ordinary lives.", "https://upload.wikimedia.org/wikipedia/en/8/8c/TheLoveOfAGoodWoman.jpg", 5.99m, "The Love of a Good Woman" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, 1, "Its principal characters are married zoologists Joseph and Celice and their daughter Syl. The story tells of how Joseph and Celice, on a day trip to the dunes where they met as students, are murdered by an opportunistic thief. Their bodies lie undiscovered for several days, during the course of which their estranged daughter is made aware of their disappearance and, eventually, discovery. The novel dwells heavily on the themes of bodily decomposition and filial bereavement.", "https://upload.wikimedia.org/wikipedia/en/9/9b/BeingDead.jpg", 3.99m, "Being Dead" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
