using Microsoft.EntityFrameworkCore.Migrations;

namespace YmagiWebMvc.Migrations
{
    public partial class Atualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Observacao",
                table: "Usuario",
                newName: "Sexo");

            migrationBuilder.AddColumn<string>(
                name: "EstadoCivil",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Filhos",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rg",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Filhos",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Rg",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "Sexo",
                table: "Usuario",
                newName: "Observacao");
        }
    }
}
