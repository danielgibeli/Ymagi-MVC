using Microsoft.EntityFrameworkCore.Migrations;

namespace YmagiWebMvc.Migrations
{
    public partial class NovaTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membro_Osc_OScId",
                table: "Membro");

            migrationBuilder.RenameColumn(
                name: "OScId",
                table: "Membro",
                newName: "OscId");

            migrationBuilder.RenameIndex(
                name: "IX_Membro_OScId",
                table: "Membro",
                newName: "IX_Membro_OscId");

            migrationBuilder.AddForeignKey(
                name: "FK_Membro_Osc_OscId",
                table: "Membro",
                column: "OscId",
                principalTable: "Osc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membro_Osc_OscId",
                table: "Membro");

            migrationBuilder.RenameColumn(
                name: "OscId",
                table: "Membro",
                newName: "OScId");

            migrationBuilder.RenameIndex(
                name: "IX_Membro_OscId",
                table: "Membro",
                newName: "IX_Membro_OScId");

            migrationBuilder.AddForeignKey(
                name: "FK_Membro_Osc_OScId",
                table: "Membro",
                column: "OScId",
                principalTable: "Osc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
