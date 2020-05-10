﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YmagiWebMvc.Models;

namespace YmagiWebMvc.Migrations
{
    [DbContext(typeof(YmagiWebMvcContext))]
    [Migration("20200501203810_Inicio")]
    partial class Inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("Status");

                    b.Property<double>("Total");

                    b.Property<int?>("membroId");

                    b.HasKey("Id");

                    b.HasIndex("membroId");

                    b.ToTable("Doacao");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Osc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contato");

                    b.Property<string>("Email");

                    b.Property<string>("Endereço");

                    b.Property<string>("NomeFantasia");

                    b.Property<string>("RazaoSocial");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Osc");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.membro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Celular");

                    b.Property<string>("Email");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.Property<int?>("OscId");

                    b.Property<double>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("OscId");

                    b.ToTable("membro");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.Doacao", b =>
                {
                    b.HasOne("YmagiWebMvc.Models.membro", "membro")
                        .WithMany("Doacoes")
                        .HasForeignKey("membroId");
                });

            modelBuilder.Entity("YmagiWebMvc.Models.membro", b =>
                {
                    b.HasOne("YmagiWebMvc.Models.Osc", "Osc")
                        .WithMany("Membros")
                        .HasForeignKey("OscId");
                });
#pragma warning restore 612, 618
        }
    }
}
