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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Entrega", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int?>("MembroId");

                    b.Property<int?>("ProdutoId");

                    b.Property<double>("Quantidade");

                    b.Property<int>("Status");

                    b.Property<int?>("UsuarioId");

                    b.Property<double>("ValorTotal");

                    b.Property<double>("ValorUnit");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Entrega");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Cnpj");

                    b.Property<string>("Complemento");

                    b.Property<string>("Contato");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Endereço");

                    b.Property<string>("Estado");

                    b.Property<string>("InscEstadual");

                    b.Property<int?>("MembroId");

                    b.Property<string>("NomeFantasia");

                    b.Property<string>("Numero");

                    b.Property<string>("RazaoSocial");

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Membro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Estado");

                    b.Property<string>("EstadoCivil");

                    b.Property<string>("Filhos");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<int?>("OscId");

                    b.Property<string>("Rg");

                    b.Property<string>("Sexo");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("OscId");

                    b.ToTable("Membro");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Osc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Cnpj");

                    b.Property<string>("Complemento");

                    b.Property<string>("Contato");

                    b.Property<string>("Email");

                    b.Property<string>("Endereço");

                    b.Property<string>("Estado");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

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

                    b.Property<int?>("UsuarioId");

                    b.Property<double>("ValorTotal");

                    b.Property<double>("ValorUnit");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("MembroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Recebimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int?>("FornecedorId");

                    b.Property<int?>("MembroId");

                    b.Property<int?>("ProdutoId");

                    b.Property<double>("Quantidade");

                    b.Property<int>("Status");

                    b.Property<int?>("UsuarioId");

                    b.Property<double>("ValorTotal");

                    b.Property<double>("ValorUnit");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("MembroId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Recebimento");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Estado");

                    b.Property<string>("EstadoCivil");

                    b.Property<string>("Filhos");

                    b.Property<int?>("MembroId");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<string>("Rg");

                    b.Property<string>("Sexo");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Entrega", b =>
                {
                    b.HasOne("YmagiWebMvc.Models.Membro", "Membro")
                        .WithMany("Entregas")
                        .HasForeignKey("MembroId");

                    b.HasOne("YmagiWebMvc.Models.Produto", "Produto")
                        .WithMany("Entregas")
                        .HasForeignKey("ProdutoId");

                    b.HasOne("YmagiWebMvc.Models.Usuario", "Usuario")
                        .WithMany("Entregas")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Fornecedor", b =>
                {
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
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId");

                    b.HasOne("YmagiWebMvc.Models.Membro", "Membro")
                        .WithMany("Produtos")
                        .HasForeignKey("MembroId");

                    b.HasOne("YmagiWebMvc.Models.Usuario", "Usuario")
                        .WithMany("Produtos")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Recebimento", b =>
                {
                    b.HasOne("YmagiWebMvc.Models.Fornecedor", "Fornecedor")
                        .WithMany("Recebimentos")
                        .HasForeignKey("FornecedorId");

                    b.HasOne("YmagiWebMvc.Models.Membro", "Membro")
                        .WithMany("Recebimentos")
                        .HasForeignKey("MembroId");

                    b.HasOne("YmagiWebMvc.Models.Produto", "Produto")
                        .WithMany("Recebimentos")
                        .HasForeignKey("ProdutoId");

                    b.HasOne("YmagiWebMvc.Models.Usuario", "Usuario")
                        .WithMany("Recebimentos")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Usuario", b =>
                {
                    b.HasOne("YmagiWebMvc.Models.Membro", "Membro")
                        .WithMany()
                        .HasForeignKey("MembroId");
                });
#pragma warning restore 612, 618
        }
    }
}
