using Microsoft.EntityFrameworkCore.Migrations;

namespace YmagiWebMvc.Migrations
{
    public partial class TabelasId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doacao_Membro_MembroId",
                table: "Doacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Doacao_Usuario_UsuarioId",
                table: "Doacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Membro_MembroId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Usuario_UsuarioId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Membro_MembroId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Membro_Osc_OscId",
                table: "Membro");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Fornecedor_FornecedorId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Membro_MembroId",
                table: "Recebimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Usuario_UsuarioId",
                table: "Recebimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Membro_MembroId",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Osc_OscId",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "OscId",
                table: "Membro",
                newName: "OScId");

            migrationBuilder.RenameIndex(
                name: "IX_Membro_OscId",
                table: "Membro",
                newName: "IX_Membro_OScId");

            migrationBuilder.AlterColumn<int>(
                name: "OscId",
                table: "Usuario",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Usuario",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Recebimento",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Recebimento",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Produto",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OScId",
                table: "Membro",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Fornecedor",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Entrega",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Entrega",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Doacao",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Doacao",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Doacao_Membro_MembroId",
                table: "Doacao",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doacao_Usuario_UsuarioId",
                table: "Doacao",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Membro_MembroId",
                table: "Entrega",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Usuario_UsuarioId",
                table: "Entrega",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Membro_MembroId",
                table: "Fornecedor",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Membro_Osc_OScId",
                table: "Membro",
                column: "OScId",
                principalTable: "Osc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Fornecedor_FornecedorId",
                table: "Produto",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Membro_MembroId",
                table: "Recebimento",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Usuario_UsuarioId",
                table: "Recebimento",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Membro_MembroId",
                table: "Usuario",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Osc_OscId",
                table: "Usuario",
                column: "OscId",
                principalTable: "Osc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doacao_Membro_MembroId",
                table: "Doacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Doacao_Usuario_UsuarioId",
                table: "Doacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Membro_MembroId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Usuario_UsuarioId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Membro_MembroId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Membro_Osc_OScId",
                table: "Membro");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Fornecedor_FornecedorId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Membro_MembroId",
                table: "Recebimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Usuario_UsuarioId",
                table: "Recebimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Membro_MembroId",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Osc_OscId",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "OScId",
                table: "Membro",
                newName: "OscId");

            migrationBuilder.RenameIndex(
                name: "IX_Membro_OScId",
                table: "Membro",
                newName: "IX_Membro_OscId");

            migrationBuilder.AlterColumn<int>(
                name: "OscId",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Recebimento",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Recebimento",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Produto",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "OscId",
                table: "Membro",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Fornecedor",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Entrega",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Entrega",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Doacao",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Doacao",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Doacao_Membro_MembroId",
                table: "Doacao",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doacao_Usuario_UsuarioId",
                table: "Doacao",
                column: "UsuarioId",
                principalTable: "Usuario",
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
                name: "FK_Entrega_Usuario_UsuarioId",
                table: "Entrega",
                column: "UsuarioId",
                principalTable: "Usuario",
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
                name: "FK_Produto_Fornecedor_FornecedorId",
                table: "Produto",
                column: "FornecedorId",
                principalTable: "Fornecedor",
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
                name: "FK_Recebimento_Usuario_UsuarioId",
                table: "Recebimento",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Membro_MembroId",
                table: "Usuario",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Osc_OscId",
                table: "Usuario",
                column: "OscId",
                principalTable: "Osc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
