using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YmagiWebMvc.Migrations
{
    public partial class AcertoTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrega_Osc_OscId",
                table: "Entrega");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Fornecedor_FornecedorId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Recebimento_Osc_OscId",
                table: "Recebimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Osc_OscId",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "Doacao");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_OscId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Recebimento_OscId",
                table: "Recebimento");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedor_FornecedorId",
                table: "Fornecedor");

            migrationBuilder.DropIndex(
                name: "IX_Entrega_OscId",
                table: "Entrega");

            migrationBuilder.DropColumn(
                name: "OscId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "OscId",
                table: "Recebimento");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "OscId",
                table: "Entrega");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OscId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OscId",
                table: "Recebimento",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "Fornecedor",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OscId",
                table: "Entrega",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Doacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    MembroId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Total = table.Column<double>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doacao_Membro_MembroId",
                        column: x => x.MembroId,
                        principalTable: "Membro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doacao_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_OscId",
                table: "Usuario",
                column: "OscId");

            migrationBuilder.CreateIndex(
                name: "IX_Recebimento_OscId",
                table: "Recebimento",
                column: "OscId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_FornecedorId",
                table: "Fornecedor",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrega_OscId",
                table: "Entrega",
                column: "OscId");

            migrationBuilder.CreateIndex(
                name: "IX_Doacao_MembroId",
                table: "Doacao",
                column: "MembroId");

            migrationBuilder.CreateIndex(
                name: "IX_Doacao_UsuarioId",
                table: "Doacao",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrega_Osc_OscId",
                table: "Entrega",
                column: "OscId",
                principalTable: "Osc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Fornecedor_FornecedorId",
                table: "Fornecedor",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recebimento_Osc_OscId",
                table: "Recebimento",
                column: "OscId",
                principalTable: "Osc",
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
