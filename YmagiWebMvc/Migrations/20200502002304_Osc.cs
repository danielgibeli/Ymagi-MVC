using Microsoft.EntityFrameworkCore.Migrations;

namespace YmagiWebMvc.Migrations
{
    public partial class Osc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_membro_Osc_OscId",
                table: "membro");

            migrationBuilder.AlterColumn<int>(
                name: "OscId",
                table: "membro",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_membro_Osc_OscId",
                table: "membro",
                column: "OscId",
                principalTable: "Osc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_membro_Osc_OscId",
                table: "membro");

            migrationBuilder.AlterColumn<int>(
                name: "OscId",
                table: "membro",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_membro_Osc_OscId",
                table: "membro",
                column: "OscId",
                principalTable: "Osc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
