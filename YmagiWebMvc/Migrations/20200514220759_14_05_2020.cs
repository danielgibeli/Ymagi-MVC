using Microsoft.EntityFrameworkCore.Migrations;

namespace YmagiWebMvc.Migrations
{
    public partial class _14_05_2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Recebimento",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Quantidade",
                table: "Recebimento",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ValorTotal",
                table: "Recebimento",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ValorUnit",
                table: "Recebimento",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Produto",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InscEstadual",
                table: "Fornecedor",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Entrega",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Quantidade",
                table: "Entrega",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Recebimento_ProdutoId",
                table: "Recebimento",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_UsuarioId",
                table: "Produto",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrega_ProdutoId",
                table: "Entrega",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Produto_ProdutoId",
                table: "Entrega",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Usuario_UsuarioId",
                table: "Produto",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Produto_ProdutoId",
                table: "Recebimento",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Produto_ProdutoId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Usuario_UsuarioId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Produto_ProdutoId",
                table: "Recebimento");

            migrationBuilder.DropIndex(
                name: "IX_Recebimento_ProdutoId",
                table: "Recebimento");

            migrationBuilder.DropIndex(
                name: "IX_Produto_UsuarioId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Entrega_ProdutoId",
                table: "Entrega");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Recebimento");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Recebimento");

            migrationBuilder.DropColumn(
                name: "ValorTotal",
                table: "Recebimento");

            migrationBuilder.DropColumn(
                name: "ValorUnit",
                table: "Recebimento");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "InscEstadual",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Entrega");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Entrega");
        }
    }
}
