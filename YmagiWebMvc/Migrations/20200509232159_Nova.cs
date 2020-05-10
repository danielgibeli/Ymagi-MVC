using Microsoft.EntityFrameworkCore.Migrations;

namespace YmagiWebMvc.Migrations
{
    public partial class Nova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doacao_membro_MembroId",
                table: "Doacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_membro_MembroId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_membro_MembroId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_membro_Osc_OscId",
                table: "membro");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_membro_MembroId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_membro_MembroId",
                table: "Recebimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_membro_MembroId",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_membro",
                table: "membro");

            migrationBuilder.RenameTable(
                name: "membro",
                newName: "Membro");

            migrationBuilder.RenameIndex(
                name: "IX_membro_OscId",
                table: "Membro",
                newName: "IX_Membro_OscId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Membro",
                table: "Membro",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doacao_Membro_MembroId",
                table: "Doacao",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Membro_MembroId",
                table: "Entrega",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Membro_MembroId",
                table: "Fornecedor",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Membro_Osc_OscId",
                table: "Membro",
                column: "OscId",
                principalTable: "Osc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Membro_MembroId",
                table: "Produto",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Membro_MembroId",
                table: "Recebimento",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Membro_MembroId",
                table: "Usuario",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doacao_Membro_MembroId",
                table: "Doacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Membro_MembroId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Membro_MembroId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Membro_Osc_OscId",
                table: "Membro");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Membro_MembroId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Membro_MembroId",
                table: "Recebimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Membro_MembroId",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Membro",
                table: "Membro");

            migrationBuilder.RenameTable(
                name: "Membro",
                newName: "membro");

            migrationBuilder.RenameIndex(
                name: "IX_Membro_OscId",
                table: "membro",
                newName: "IX_membro_OscId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_membro",
                table: "membro",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doacao_membro_MembroId",
                table: "Doacao",
                column: "MembroId",
                principalTable: "membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_membro_MembroId",
                table: "Entrega",
                column: "MembroId",
                principalTable: "membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_membro_MembroId",
                table: "Fornecedor",
                column: "MembroId",
                principalTable: "membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_membro_Osc_OscId",
                table: "membro",
                column: "OscId",
                principalTable: "Osc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_membro_MembroId",
                table: "Produto",
                column: "MembroId",
                principalTable: "membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_membro_MembroId",
                table: "Recebimento",
                column: "MembroId",
                principalTable: "membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_membro_MembroId",
                table: "Usuario",
                column: "MembroId",
                principalTable: "membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
