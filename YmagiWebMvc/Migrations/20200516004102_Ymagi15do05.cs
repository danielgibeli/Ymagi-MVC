using Microsoft.EntityFrameworkCore.Migrations;

namespace YmagiWebMvc.Migrations
{
    public partial class Ymagi15do05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Recebimento");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Entrega",
                newName: "ValorUnit");

            migrationBuilder.AddColumn<double>(
                name: "ValorTotal",
                table: "Entrega",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorTotal",
                table: "Entrega");

            migrationBuilder.RenameColumn(
                name: "ValorUnit",
                table: "Entrega",
                newName: "Total");

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Recebimento",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
