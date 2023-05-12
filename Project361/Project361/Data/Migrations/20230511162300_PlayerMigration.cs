using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project361.Data.Migrations
{
    public partial class PlayerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GameId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Score = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "GameId", "Name", "Score" },
                values: new object[] { 1, 1, "Sam", 0 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "GameId", "Name", "Score" },
                values: new object[] { 2, 1, "Ethan", 0 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "GameId", "Name", "Score" },
                values: new object[] { 3, 1, "Aden", 0 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "GameId", "Name", "Score" },
                values: new object[] { 4, 1, "Pranav", 0 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "GameId", "Name", "Score" },
                values: new object[] { 5, 1, "Chris", 0 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "GameId", "Name", "Score" },
                values: new object[] { 6, 1, "Indigo", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
