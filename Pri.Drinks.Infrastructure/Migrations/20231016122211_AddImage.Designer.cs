﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pri.Drinks.Infrastructure.Data;

#nullable disable

namespace Pri.Drinks.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231016122211_AddImage")]
    partial class AddImage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DrinkProperty", b =>
                {
                    b.Property<int>("DrinksId")
                        .HasColumnType("int");

                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.HasKey("DrinksId", "PropertiesId");

                    b.HasIndex("PropertiesId");

                    b.ToTable("DrinkProperty");

                    b.HasData(
                        new
                        {
                            DrinksId = 1,
                            PropertiesId = 1
                        },
                        new
                        {
                            DrinksId = 1,
                            PropertiesId = 2
                        },
                        new
                        {
                            DrinksId = 2,
                            PropertiesId = 1
                        },
                        new
                        {
                            DrinksId = 2,
                            PropertiesId = 2
                        },
                        new
                        {
                            DrinksId = 3,
                            PropertiesId = 2
                        },
                        new
                        {
                            DrinksId = 3,
                            PropertiesId = 1
                        });
                });

            modelBuilder.Entity("Pri.Drinks.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 10, 16, 12, 22, 10, 897, DateTimeKind.Utc).AddTicks(8570),
                            Name = "Beer"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 10, 16, 12, 22, 10, 897, DateTimeKind.Utc).AddTicks(8572),
                            Name = "Spirits"
                        });
                });

            modelBuilder.Entity("Pri.Drinks.Core.Entities.Drink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AlcoholPercentage")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Drinks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlcoholPercentage = 8,
                            CategoryId = 1,
                            Created = new DateTime(2023, 10, 16, 12, 22, 10, 897, DateTimeKind.Utc).AddTicks(8575),
                            Name = "Duvel"
                        },
                        new
                        {
                            Id = 2,
                            AlcoholPercentage = 38,
                            CategoryId = 2,
                            Created = new DateTime(2023, 10, 16, 12, 22, 10, 897, DateTimeKind.Utc).AddTicks(8576),
                            Name = "Tequila"
                        },
                        new
                        {
                            Id = 3,
                            AlcoholPercentage = 35,
                            CategoryId = 2,
                            Created = new DateTime(2023, 10, 16, 12, 22, 10, 897, DateTimeKind.Utc).AddTicks(8577),
                            Name = "Irish"
                        });
                });

            modelBuilder.Entity("Pri.Drinks.Core.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 10, 16, 12, 22, 10, 897, DateTimeKind.Utc).AddTicks(8574),
                            Name = "Sweet"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 10, 16, 12, 22, 10, 897, DateTimeKind.Utc).AddTicks(8574),
                            Name = "bitter"
                        });
                });

            modelBuilder.Entity("DrinkProperty", b =>
                {
                    b.HasOne("Pri.Drinks.Core.Entities.Drink", null)
                        .WithMany()
                        .HasForeignKey("DrinksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pri.Drinks.Core.Entities.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pri.Drinks.Core.Entities.Drink", b =>
                {
                    b.HasOne("Pri.Drinks.Core.Entities.Category", "Category")
                        .WithMany("Drinks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Pri.Drinks.Core.Entities.Category", b =>
                {
                    b.Navigation("Drinks");
                });
#pragma warning restore 612, 618
        }
    }
}
