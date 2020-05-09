using Microsoft.EntityFrameworkCore.Migrations;

namespace YmagiWebMvc.Migrations
{
    public partial class AtualizaEndOsc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Osc",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Osc",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Osc",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Osc",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Osc",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Osc");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Osc");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Osc");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Osc");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Osc");
        }
    }
}
