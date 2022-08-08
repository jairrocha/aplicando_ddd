﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurante.Infra.Data.Contextos;

namespace Restaurante.Infra.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220531225648_Relacionamento_Cardapio_x_Prato")]
    partial class Relacionamento_Cardapio_x_Prato
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Restaurante.Dominio.Entidades.Cardapio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CARDAPIO")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodDia")
                        .HasColumnType("int")
                        .HasColumnName("COD_DIA");

                    b.Property<string>("Dia")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("DESC_DIA_SEMANA");

                    b.HasKey("Id");

                    b.ToTable("TB_CARDAPIO");
                });

            modelBuilder.Entity("Restaurante.Dominio.Entidades.Prato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PRATO")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("NOME");

                    b.Property<decimal>("Preco")
                        .HasColumnType("NUMERIC(15,2)")
                        .HasColumnName("PRECO");

                    b.HasKey("Id");

                    b.ToTable("TB_PRATO");
                });

            modelBuilder.Entity("Restaurante.Dominio.Entidades.PratoDia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PRATO_DIA")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardapioId")
                        .HasColumnType("int")
                        .HasColumnName("ID_CARDAPIO");

                    b.Property<int>("PratoId")
                        .HasColumnType("int")
                        .HasColumnName("ID_PRATO");

                    b.HasKey("Id");

                    b.HasIndex("PratoId");

                    b.HasIndex("CardapioId", "PratoId")
                        .IsUnique();

                    b.ToTable("TB_PRATO_DIA");
                });

            modelBuilder.Entity("Restaurante.Dominio.Entidades.PratoDia", b =>
                {
                    b.HasOne("Restaurante.Dominio.Entidades.Cardapio", "Cardapio")
                        .WithMany("PratosDia")
                        .HasForeignKey("CardapioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Restaurante.Dominio.Entidades.Prato", "Prato")
                        .WithMany("PratosDia")
                        .HasForeignKey("PratoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cardapio");

                    b.Navigation("Prato");
                });

            modelBuilder.Entity("Restaurante.Dominio.Entidades.Cardapio", b =>
                {
                    b.Navigation("PratosDia");
                });

            modelBuilder.Entity("Restaurante.Dominio.Entidades.Prato", b =>
                {
                    b.Navigation("PratosDia");
                });
#pragma warning restore 612, 618
        }
    }
}
