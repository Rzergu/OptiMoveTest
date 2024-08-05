﻿// <auto-generated />
using GlobalETestLV.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GlobalETestLV.Migrations.Customer
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20240803070611_AddQuartz")]
    partial class AddQuartz
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GlobalETestLV.Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<byte>("Age")
                        .HasColumnType("smallint");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<int>("Deposit")
                        .HasColumnType("integer");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<bool>("IsNew")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}