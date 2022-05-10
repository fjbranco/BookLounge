using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLounge.Data.Migrations
{
    public partial class CorrecaoAtributosClasses01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Encomendas_Utilizadores_UtilizadorFK",
                table: "Encomendas");

            migrationBuilder.DropTable(
                name: "TemaLivros");

            migrationBuilder.DropColumn(
                name: "DataRececao",
                table: "Encomendas");

            migrationBuilder.RenameColumn(
                name: "ValorEncomenda",
                table: "Encomendas",
                newName: "IvaEncomenda");

            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Livros",
                type: "decimal(18,2)",
                maxLength: 6,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Livros",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 13);

            migrationBuilder.AddColumn<int>(
                name: "IVA",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UtilizadorFK",
                table: "Encomendas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Encomendas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "IvaEncomenda",
                table: "EncomendaLivros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecoEncomenda",
                table: "EncomendaLivros",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Qtd",
                table: "EncomendaLivros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "GeneroLivro",
                columns: table => new
                {
                    ListaLivrosId = table.Column<int>(type: "int", nullable: false),
                    ListaTemasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroLivro", x => new { x.ListaLivrosId, x.ListaTemasId });
                    table.ForeignKey(
                        name: "FK_GeneroLivro_Livros_ListaLivrosId",
                        column: x => x.ListaLivrosId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroLivro_Temas_ListaTemasId",
                        column: x => x.ListaTemasId,
                        principalTable: "Temas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeneroLivro_ListaTemasId",
                table: "GeneroLivro",
                column: "ListaTemasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Encomendas_Utilizadores_UtilizadorFK",
                table: "Encomendas",
                column: "UtilizadorFK",
                principalTable: "Utilizadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Encomendas_Utilizadores_UtilizadorFK",
                table: "Encomendas");

            migrationBuilder.DropTable(
                name: "GeneroLivro");

            migrationBuilder.DropColumn(
                name: "IVA",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Encomendas");

            migrationBuilder.DropColumn(
                name: "IvaEncomenda",
                table: "EncomendaLivros");

            migrationBuilder.DropColumn(
                name: "PrecoEncomenda",
                table: "EncomendaLivros");

            migrationBuilder.DropColumn(
                name: "Qtd",
                table: "EncomendaLivros");

            migrationBuilder.RenameColumn(
                name: "IvaEncomenda",
                table: "Encomendas",
                newName: "ValorEncomenda");

            migrationBuilder.AlterColumn<string>(
                name: "Preco",
                table: "Livros",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<int>(
                name: "ISBN",
                table: "Livros",
                type: "int",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<int>(
                name: "UtilizadorFK",
                table: "Encomendas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataRececao",
                table: "Encomendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "TemaLivros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LivroTFK = table.Column<int>(type: "int", nullable: false),
                    TemaFK = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_TemaLivros_LivroTFK",
                table: "TemaLivros",
                column: "LivroTFK");

            migrationBuilder.CreateIndex(
                name: "IX_TemaLivros_TemaFK",
                table: "TemaLivros",
                column: "TemaFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Encomendas_Utilizadores_UtilizadorFK",
                table: "Encomendas",
                column: "UtilizadorFK",
                principalTable: "Utilizadores",
                principalColumn: "Id");
        }
    }
}
