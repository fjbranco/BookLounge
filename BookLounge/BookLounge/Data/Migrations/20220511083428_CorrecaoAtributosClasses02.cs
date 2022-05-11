using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLounge.Data.Migrations
{
    public partial class CorrecaoAtributosClasses02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Utilizadores");

            migrationBuilder.RenameColumn(
                name: "DesignacaoTema",
                table: "Temas",
                newName: "DesignacaoGenero");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Encomendas",
                newName: "EstadoEncomenda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DesignacaoGenero",
                table: "Temas",
                newName: "DesignacaoTema");

            migrationBuilder.RenameColumn(
                name: "EstadoEncomenda",
                table: "Encomendas",
                newName: "Estado");

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Utilizadores",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Utilizadores",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");
        }
    }
}
