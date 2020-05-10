﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YmagiWebMvc.Models;

namespace YmagiWebMvc.Migrations
{
    [DbContext(typeof(YmagiWebMvcContext))]
    partial class YmagiWebMvcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("YmagiWebMvc.Models.Doacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int?>("MembroId");

                    b.Property<int>("Status");

                    b.Property<double>("Total");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Doacao");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Entrega", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int?>("MembroId");

                    b.Property<int?>("OscId");

                    b.Property<int>("Status");

                    b.Property<double>("Total");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.HasIndex("OscId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Entrega");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cidade");

                    b.Property<string>("Cnpj");

                    b.Property<string>("Complemento");

                    b.Property<string>("Contato");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Endereço");

                    b.Property<string>("Estado");

                    b.Property<int?>("FornecedorId");

                    b.Property<int?>("MembroId");

                    b.Property<string>("NomeFantasia");

                    b.Property<int>("Numero");

                    b.Property<string>("RazaoSocial");

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("MembroId");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Membro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<int>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<int>("Cpf");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Estado");

                    b.Property<string>("EstadoCivil");

                    b.Property<int>("Filhos");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.Property<int>("Numero");

                    b.Property<int?>("OscId");

                    b.Property<int>("Rg");

                    b.Property<string>("Rua");

                    b.Property<string>("Sexo");

                    b.Property<int>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("OscId");

                    b.ToTable("Membro");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Osc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cidade");

                    b.Property<string>("Cnpj");

                    b.Property<string>("Complemento");

                    b.Property<string>("Contato");

                    b.Property<string>("Email");

                    b.Property<string>("Endereço");

                    b.Property<string>("Estado");

                    b.Property<string>("Nome");

                    b.Property<int>("Numero");

                    b.Property<string>("Observacao");

                    b.Property<string>("RazaoSocial");

                    b.Property<string>("Responsavel");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Osc");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int?>("FornecedorId");

                    b.Property<int?>("MembroId");

                    b.Property<string>("Nome");

                    b.Property<double>("Quantidade");

                    b.Property<double>("Total");

                    b.Property<string>("Unidade");

                    b.Property<double>("ValorTotal");

                    b.Property<double>("ValorUnit");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("MembroId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Recebimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int?>("FornecedorId");

                    b.Property<int?>("MembroId");

                    b.Property<int?>("OscId");

                    b.Property<int>("Status");

                    b.Property<double>("Total");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("MembroId");

                    b.HasIndex("OscId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Recebimento");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<int>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<int>("Cpf");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Estado");

                    b.Property<string>("EstadoCivil");

                    b.Property<int>("Filhos");

                    b.Property<int?>("MembroId");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.Property<int>("Numero");

                    b.Property<int?>("OscId");

                    b.Property<int>("Rg");

                    b.Property<string>("Rua");

                    b.Property<string>("Sexo");

                    b.Property<int>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.HasIndex("OscId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Doacao", b =>
                {
                    b.HasOne("YmagiWebMvc.Models.Membro", "Membro")
                        .WithMany()
                        .HasForeignKey("MembroId");

                    b.HasOne("YmagiWebMvc.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Entrega", b =>
                {
                    b.HasOne("YmagiWebMvc.Models.Membro", "Membro")
                        .WithMany("Entregas")
                        .HasForeignKey("MembroId");

                    b.HasOne("YmagiWebMvc.Models.Osc")
                        .WithMany("Entregas")
                        .HasForeignKey("OscId");

                    b.HasOne("YmagiWebMvc.Models.Usuario", "Usuario")
                        .WithMany("Entregas")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Fornecedor", b =>
                {
                    b.HasOne("YmagiWebMvc.Models.Fornecedor")
                        .WithMany("Fornecedores")
                        .HasForeignKey("FornecedorId");

                    b.HasOne("YmagiWebMvc.Models.Membro", "Membro")
                        .WithMany("Fornecedores")
                        .HasForeignKey("MembroId");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Membro", b =>
                {
                    b.HasOne("YmagiWebMvc.Models.Osc", "Osc")
                        .WithMany("Membros")
                        .HasForeignKey("OscId");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Produto", b =>
                {
                    b.HasOne("YmagiWebMvc.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");

                    b.HasOne("YmagiWebMvc.Models.Membro")
                        .WithMany("Produtos")
                        .HasForeignKey("MembroId");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Recebimento", b =>
                {
                    b.HasOne("YmagiWebMvc.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");

                    b.HasOne("YmagiWebMvc.Models.Membro", "Membro")
                        .WithMany("Recebimentos")
                        .HasForeignKey("MembroId");

                    b.HasOne("YmagiWebMvc.Models.Osc")
                        .WithMany("Recebimentos")
                        .HasForeignKey("OscId");

                    b.HasOne("YmagiWebMvc.Models.Usuario", "Usuario")
                        .WithMany("Recebimentos")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Usuario", b =>
                {
                    b.HasOne("YmagiWebMvc.Models.Membro", "Membro")
                        .WithMany("Usuarios")
                        .HasForeignKey("MembroId");

                    b.HasOne("YmagiWebMvc.Models.Osc", "Osc")
                        .WithMany("Usuarios")
                        .HasForeignKey("OscId");
                });
#pragma warning restore 612, 618
        }
    }
}
