﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroAnimaisAPI.Data;

#nullable disable

namespace RegistroAnimaisAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231213005614_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RegistroAnimaisAPI.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Classificacao")
                        .HasColumnType("int");

                    b.Property<bool>("EstaPrenha")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("FiliacaoId")
                        .HasColumnType("int");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Observacao")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("PeriodoCio")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("PeriodoGestacao")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Peso")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Animal");
                });
#pragma warning restore 612, 618
        }
    }
}
