﻿// <auto-generated />
using CadastroDeEtiquetas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CadastroDeEtiquetas.Migrations
{
    [DbContext(typeof(CadastroDeEtiquetasContext))]
    partial class CadastroDeEtiquetasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CadastroDeEtiquetas.Models.Etiqueta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Densidade")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstruturaEtiqueta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FormularioId")
                        .HasColumnType("int");

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LarguraImpressao")
                        .HasColumnType("int");

                    b.Property<int>("Linguagem")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<int>("Velocidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FormularioId");

                    b.ToTable("Etiquetas");
                });

            modelBuilder.Entity("CadastroDeEtiquetas.Models.Formulario", b =>
                {
                    b.Property<int>("FormularioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<int>("Colunas")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fixacao")
                        .HasColumnType("int");

                    b.Property<double>("GapColuna")
                        .HasColumnType("float");

                    b.Property<double>("GapLinha")
                        .HasColumnType("float");

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Largura")
                        .HasColumnType("float");

                    b.Property<int>("Rfid")
                        .HasColumnType("int");

                    b.HasKey("FormularioId");

                    b.ToTable("Formularios");
                });

            modelBuilder.Entity("CadastroDeEtiquetas.Models.Etiqueta", b =>
                {
                    b.HasOne("CadastroDeEtiquetas.Models.Formulario", "Formulario")
                        .WithMany("Etiquetas")
                        .HasForeignKey("FormularioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
