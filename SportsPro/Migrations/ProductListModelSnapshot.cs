﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsPro.Models;

#nullable disable

namespace SportsPro.Migrations
{
    [DbContext(typeof(ProductList))]
    partial class ProductListModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SportsPro.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tourmanment Master 1.0",
                            Price = 4.99m,
                            ProductCode = "TRYNY10",
                            ReleaseDate = new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Name = "League Scheduler 1.0",
                            Price = 7.99m,
                            ProductCode = "LEAG10",
                            ReleaseDate = new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Name = "Draft Manager 1.0",
                            Price = 4.99m,
                            ProductCode = "DRAFT10",
                            ReleaseDate = new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Name = "Team Manager 1.0",
                            Price = 4.99m,
                            ProductCode = "TEAM10",
                            ReleaseDate = new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Name = "Tourmanment Master 2.0",
                            Price = 5.99m,
                            ProductCode = "TEAM20",
                            ReleaseDate = new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Name = "Draft Manager 2.0",
                            Price = 5.99m,
                            ProductCode = "TRYNY10",
                            ReleaseDate = new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
