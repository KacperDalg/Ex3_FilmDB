using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmBase.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Surname = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Surname);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "ActorFilm",
                columns: table => new
                {
                    ActorsSurname = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FilmsTitle = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorFilm", x => new { x.ActorsSurname, x.FilmsTitle });
                    table.ForeignKey(
                        name: "FK_ActorFilm_Actors_ActorsSurname",
                        column: x => x.ActorsSurname,
                        principalTable: "Actors",
                        principalColumn: "Surname",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorFilm_Films_FilmsTitle",
                        column: x => x.FilmsTitle,
                        principalTable: "Films",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorFilm_FilmsTitle",
                table: "ActorFilm",
                column: "FilmsTitle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorFilm");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
