using Microsoft.EntityFrameworkCore.Migrations;

namespace YmagiWebMvc.Migrations
{
    public partial class FornecedorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Fornecedor_FornecedorId",
                table: "Recebimento");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Recebimento",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Fornecedor_FornecedorId",
                table: "Recebimento",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Fornecedor_FornecedorId",
                table: "Recebimento");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Recebimento",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Fornecedor_FornecedorId",
                table: "Recebimento",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
