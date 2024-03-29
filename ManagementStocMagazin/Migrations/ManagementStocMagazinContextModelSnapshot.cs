﻿// <auto-generated />
using System;
using ManagementStocMagazin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManagementStocMagazin.Migrations
{
    [DbContext(typeof(ManagementStocMagazinContext))]
    partial class ManagementStocMagazinContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ManagementStocMagazin.Models.CatalogProduse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descriere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pret")
                        .HasColumnType("int");

                    b.Property<int>("Stoc")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("CatalogProduse");
                });

            modelBuilder.Entity("ManagementStocMagazin.Models.Iesire", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantitate")
                        .HasColumnType("int");

                    b.Property<int>("CatalogProduseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataIntrarii")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriere")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CatalogProduseID");

                    b.ToTable("Iesire");
                });

            modelBuilder.Entity("ManagementStocMagazin.Models.Intrare", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantitate")
                        .HasColumnType("int");

                    b.Property<int>("CatalogProduseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataIntrarii")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriere")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CatalogProduseID");

                    b.ToTable("Intrari");
                });

            modelBuilder.Entity("ManagementStocMagazin.Models.Iesire", b =>
                {
                    b.HasOne("ManagementStocMagazin.Models.CatalogProduse", "CatalogProduse")
                        .WithMany()
                        .HasForeignKey("CatalogProduseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ManagementStocMagazin.Models.Intrare", b =>
                {
                    b.HasOne("ManagementStocMagazin.Models.CatalogProduse", "CatalogProduse")
                        .WithMany()
                        .HasForeignKey("CatalogProduseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
