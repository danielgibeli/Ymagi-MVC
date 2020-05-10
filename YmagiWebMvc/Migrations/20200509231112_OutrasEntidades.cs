using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YmagiWebMvc.Migrations
{
    public partial class OutrasEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doacao_membro_membroId",
                table: "Doacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_membro_membroId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_membro_Osc_OscId",
                table: "membro");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Produto_ProdutoId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_membro_membroId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "membro");

            migrationBuilder.RenameColumn(
                name: "membroId",
                table: "Produto",
                newName: "MembroId");

            migrationBuilder.RenameColumn(
                name: "SaldoEstoque",
                table: "Produto",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "Produto",
                newName: "FornecedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_membroId",
                table: "Produto",
                newName: "IX_Produto_MembroId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_ProdutoId",
                table: "Produto",
                newName: "IX_Produto_FornecedorId");

            migrationBuilder.RenameColumn(
                name: "NomeFantasia",
                table: "Osc",
                newName: "Responsavel");

            migrationBuilder.RenameColumn(
                name: "membroId",
                table: "Fornecedor",
                newName: "MembroId");

            migrationBuilder.RenameIndex(
                name: "IX_Fornecedor_membroId",
                table: "Fornecedor",
                newName: "IX_Fornecedor_MembroId");

            migrationBuilder.RenameColumn(
                name: "membroId",
                table: "Doacao",
                newName: "MembroId");

            migrationBuilder.RenameIndex(
                name: "IX_Doacao_membroId",
                table: "Doacao",
                newName: "IX_Doacao_MembroId");

            migrationBuilder.AddColumn<int>(
                name: "MembroId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OscId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Osc",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Osc",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Cnpj",
                table: "Osc",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Osc",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "Osc",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Telefone",
                table: "membro",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "OscId",
                table: "membro",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "membro",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "membro",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cep",
                table: "membro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "membro",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "membro",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cpf",
                table: "membro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "membro",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "membro",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstadoCivil",
                table: "membro",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Filhos",
                table: "membro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "membro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rg",
                table: "membro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Rua",
                table: "membro",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "membro",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Entrega",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Total = table.Column<double>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: true),
                    MembroId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    OscId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrega", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entrega_membro_MembroId",
                        column: x => x.MembroId,
                        principalTable: "membro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrega_Osc_OscId",
                        column: x => x.OscId,
                        principalTable: "Osc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrega_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recebimento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FornecedorId = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    Total = table.Column<double>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: true),
                    MembroId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    OscId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recebimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recebimento_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recebimento_membro_MembroId",
                        column: x => x.MembroId,
                        principalTable: "membro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recebimento_Osc_OscId",
                        column: x => x.OscId,
                        principalTable: "Osc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recebimento_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_MembroId",
                table: "Usuario",
                column: "MembroId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_OscId",
                table: "Usuario",
                column: "OscId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrega_MembroId",
                table: "Entrega",
                column: "MembroId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrega_OscId",
                table: "Entrega",
                column: "OscId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrega_UsuarioId",
                table: "Entrega",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Recebimento_FornecedorId",
                table: "Recebimento",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Recebimento_MembroId",
                table: "Recebimento",
                column: "MembroId");

            migrationBuilder.CreateIndex(
                name: "IX_Recebimento_OscId",
                table: "Recebimento",
                column: "OscId");

            migrationBuilder.CreateIndex(
                name: "IX_Recebimento_UsuarioId",
                table: "Recebimento",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doacao_membro_MembroId",
                table: "Doacao",
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
                name: "FK_Produto_Fornecedor_FornecedorId",
                table: "Produto",
                column: "FornecedorId",
                principalTable: "Fornecedor",
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
                name: "FK_Usuario_membro_MembroId",
                table: "Usuario",
                column: "MembroId",
                principalTable: "membro",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doacao_membro_MembroId",
                table: "Doacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_membro_MembroId",
                table: "Fornecedor");

            migrationBuilder.DropForeignKey(
                name: "FK_membro_Osc_OscId",
                table: "membro");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Fornecedor_FornecedorId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_membro_MembroId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_membro_MembroId",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Osc_OscId",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "Entrega");

            migrationBuilder.DropTable(
                name: "Recebimento");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_MembroId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_OscId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "MembroId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "OscId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Cnpj",
                table: "Osc");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Osc");

            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "Osc");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "membro");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "membro");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "membro");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "membro");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "membro");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "membro");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "membro");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "membro");

            migrationBuilder.DropColumn(
                name: "Filhos",
                table: "membro");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "membro");

            migrationBuilder.DropColumn(
                name: "Rg",
                table: "membro");

            migrationBuilder.DropColumn(
                name: "Rua",
                table: "membro");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "membro");

            migrationBuilder.RenameColumn(
                name: "MembroId",
                table: "Produto",
                newName: "membroId");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Produto",
                newName: "SaldoEstoque");

            migrationBuilder.RenameColumn(
                name: "FornecedorId",
                table: "Produto",
                newName: "ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_MembroId",
                table: "Produto",
                newName: "IX_Produto_membroId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_FornecedorId",
                table: "Produto",
                newName: "IX_Produto_ProdutoId");

            migrationBuilder.RenameColumn(
                name: "Responsavel",
                table: "Osc",
                newName: "NomeFantasia");

            migrationBuilder.RenameColumn(
                name: "MembroId",
                table: "Fornecedor",
                newName: "membroId");

            migrationBuilder.RenameIndex(
                name: "IX_Fornecedor_MembroId",
                table: "Fornecedor",
                newName: "IX_Fornecedor_membroId");

            migrationBuilder.RenameColumn(
                name: "MembroId",
                table: "Doacao",
                newName: "membroId");

            migrationBuilder.RenameIndex(
                name: "IX_Doacao_MembroId",
                table: "Doacao",
                newName: "IX_Doacao_membroId");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Osc",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Osc",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Telefone",
                table: "membro",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "OscId",
                table: "membro",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "membro",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Celular",
                table: "membro",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_Doacao_membro_membroId",
                table: "Doacao",
                column: "membroId",
                principalTable: "membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_membro_membroId",
                table: "Fornecedor",
                column: "membroId",
                principalTable: "membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_membro_Osc_OscId",
                table: "membro",
                column: "OscId",
                principalTable: "Osc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Produto_ProdutoId",
                table: "Produto",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_membro_membroId",
                table: "Produto",
                column: "membroId",
                principalTable: "membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
