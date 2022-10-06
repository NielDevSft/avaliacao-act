﻿// <auto-generated />
using System;
using Administrativo.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Administrativo.Migrations
{
    [DbContext(typeof(LancamentoContext))]
    [Migration("20221005203530_Criacao-Inicial")]
    partial class CriacaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Administrativo.Models.Lancamento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("DesLancament")
                        .HasColumnType("text")
                        .HasColumnName("des_lancamento");

                    b.Property<DateTime>("DtaCreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dta_create_at");

                    b.Property<DateTime>("DtaLancamento")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dta_lancamento");

                    b.Property<DateTime>("dtaUpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("dta_updated_at");

                    b.Property<int>("IndEntradaSaIda")
                        .HasColumnType("integer")
                        .HasColumnName("ind_entrada_saida");

                    b.Property<decimal>("ValLancamento")
                        .HasColumnType("numeric")
                        .HasColumnName("val_lancamento");

                    b.HasKey("Id");

                    b.ToTable("tab_lancamento");
                });
#pragma warning restore 612, 618
        }
    }
}
