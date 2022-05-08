using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLounge.Data.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Editora = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    ISBN = table.Column<int>(type: "int", maxLength: 13, nullable: false),
                    Sinopse = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    Preco = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignacaoTema = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Morada = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CodPostal = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Telemovel = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    NIF = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemaLivros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemaFK = table.Column<int>(type: "int", nullable: false),
                    LivroTFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemaLivros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemaLivros_Livros_LivroTFK",
                        column: x => x.LivroTFK,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TemaLivros_Temas_TemaFK",
                        column: x => x.TemaFK,
                        principalTable: "Temas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Encomendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataEncomenda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEnvio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataRececao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorEncomenda = table.Column<int>(type: "int", nullable: false),
                    UtilizadorFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encomendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Encomendas_Utilizadores_UtilizadorFK",
                        column: x => x.UtilizadorFK,
                        principalTable: "Utilizadores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EncomendaLivros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EncomendaFK = table.Column<int>(type: "int", nullable: false),
                    LivroFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncomendaLivros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EncomendaLivros_Encomendas_EncomendaFK",
                        column: x => x.EncomendaFK,
                        principalTable: "Encomendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EncomendaLivros_Livros_LivroFK",
                        column: x => x.LivroFK,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EncomendaLivros_EncomendaFK",
                table: "EncomendaLivros",
                column: "EncomendaFK");

            migrationBuilder.CreateIndex(
                name: "IX_EncomendaLivros_LivroFK",
                table: "EncomendaLivros",
                column: "LivroFK");

            migrationBuilder.CreateIndex(
                name: "IX_Encomendas_UtilizadorFK",
                table: "Encomendas",
                column: "UtilizadorFK");

            migrationBuilder.CreateIndex(
                name: "IX_TemaLivros_LivroTFK",
                table: "TemaLivros",
                column: "LivroTFK");

            migrationBuilder.CreateIndex(
                name: "IX_TemaLivros_TemaFK",
                table: "TemaLivros",
                column: "TemaFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EncomendaLivros");

            migrationBuilder.DropTable(
                name: "TemaLivros");

            migrationBuilder.DropTable(
                name: "Encomendas");

            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Temas");

            migrationBuilder.DropTable(
                name: "Utilizadores");
        }
    }
}
