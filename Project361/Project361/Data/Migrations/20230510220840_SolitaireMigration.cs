using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project361.Data.Migrations
{
    public partial class SolitaireMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SolitaireBoards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeckPile = table.Column<string>(type: "TEXT", nullable: true),
                    DrawPile = table.Column<string>(type: "TEXT", nullable: true),
                    CardRows = table.Column<string>(type: "TEXT", nullable: true),
                    SuitePiles = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolitaireBoards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SolitaireBoards");
        }
    }
}
