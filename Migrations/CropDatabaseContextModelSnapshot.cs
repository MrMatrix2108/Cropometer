﻿// <auto-generated />
using System;
using CropsAppMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CropsAppMVC.Migrations
{
    [DbContext(typeof(CropDatabaseContext))]
    partial class CropDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CropsAppMVC.Models.Crop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("CropExpenses")
                        .HasColumnType("float");

                    b.Property<double?>("CropIncome")
                        .HasColumnType("float");

                    b.Property<string>("CropName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("CropYield")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Crops__3214EC0729AABA17");

                    b.ToTable("Crops");
                });
#pragma warning restore 612, 618
        }
    }
}
