using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project361.Data.Migrations
{
    public partial class Deck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rank = table.Column<int>(type: "INTEGER", nullable: false),
                    Suite = table.Column<string>(type: "TEXT", nullable: true),
                    Visible = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 1, 1, "Spades", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 2, 2, "Spades", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 3, 3, "Spades", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 4, 4, "Spades", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 5, 5, "Spades", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 6, 6, "Spades", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 7, 7, "Spades", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 8, 8, "Spades", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 9, 9, "Spades", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 10, 10, "Spades", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 11, 11, "Spades", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 12, 12, "Spades", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 13, 13, "Spades", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 14, 1, "Hearts", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 15, 2, "Hearts", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 16, 3, "Hearts", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 17, 4, "Hearts", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 18, 5, "Hearts", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 19, 6, "Hearts", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 20, 7, "Hearts", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 21, 8, "Hearts", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 22, 9, "Hearts", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 23, 10, "Hearts", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 24, 11, "Hearts", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 25, 12, "Hearts", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 26, 13, "Hearts", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 27, 1, "Clubs", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 28, 2, "Clubs", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 29, 3, "Clubs", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 30, 4, "Clubs", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 31, 5, "Clubs", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 32, 6, "Clubs", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 33, 7, "Clubs", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 34, 8, "Clubs", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 35, 9, "Clubs", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 36, 10, "Clubs", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 37, 11, "Clubs", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 38, 12, "Clubs", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 39, 13, "Clubs", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 40, 1, "Diamonds", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 41, 2, "Diamonds", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 42, 3, "Diamonds", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 43, 4, "Diamonds", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 44, 5, "Diamonds", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 45, 6, "Diamonds", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 46, 7, "Diamonds", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 47, 8, "Diamonds", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 48, 9, "Diamonds", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 49, 10, "Diamonds", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 50, 11, "Diamonds", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 51, 12, "Diamonds", false });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Rank", "Suite", "Visible" },
                values: new object[] { 52, 13, "Diamonds", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
