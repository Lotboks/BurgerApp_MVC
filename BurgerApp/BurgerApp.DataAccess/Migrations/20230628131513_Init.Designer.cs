﻿// <auto-generated />
using System;
using BurgerApp.DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurgerApp.DataAccess.Migrations
{
    [DbContext(typeof(BurgerAppDbContext))]
    [Migration("20230628131513_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BurgerApp.Domain.Models.Burger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("HasFries")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegan")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Burgers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasFries = true,
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Classic Burger",
                            Price = 140
                        },
                        new
                        {
                            Id = 2,
                            HasFries = true,
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "CheeseBurger",
                            Price = 150
                        },
                        new
                        {
                            Id = 3,
                            HasFries = true,
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "SpicyBurger",
                            Price = 145
                        },
                        new
                        {
                            Id = 4,
                            HasFries = true,
                            IsVegan = true,
                            IsVegetarian = true,
                            Name = "VeggieBurger",
                            Price = 180
                        },
                        new
                        {
                            Id = 5,
                            HasFries = true,
                            IsVegan = true,
                            IsVegetarian = false,
                            Name = "Vegan Burger",
                            Price = 175
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.BurgerOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BurgerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BurgerId");

                    b.HasIndex("OrderId");

                    b.ToTable("BurgerOrder");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BurgerId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 2,
                            BurgerId = 3,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 3,
                            BurgerId = 5,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 4,
                            BurgerId = 2,
                            OrderId = 2
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeSpan>("ClosesAt")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("OpensAt")
                        .HasColumnType("time");

                    b.Property<int>("StoreLocation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClosesAt = new TimeSpan(0, 21, 0, 0, 0),
                            Name = "Valid Burgers",
                            OpensAt = new TimeSpan(0, 9, 0, 0, 0),
                            StoreLocation = 1
                        },
                        new
                        {
                            Id = 2,
                            ClosesAt = new TimeSpan(0, 21, 0, 0, 0),
                            Name = "Valid Burgers NL",
                            OpensAt = new TimeSpan(0, 9, 0, 0, 0),
                            StoreLocation = 2
                        },
                        new
                        {
                            Id = 3,
                            ClosesAt = new TimeSpan(0, 23, 0, 0, 0),
                            Name = "Valid Burgers Centar",
                            OpensAt = new TimeSpan(0, 8, 0, 0, 0),
                            StoreLocation = 3
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelivered")
                        .HasColumnType("bit");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Novo Lisice",
                            FullName = "Stojadin Stojkov",
                            IsDelivered = true,
                            LocationId = 2
                        },
                        new
                        {
                            Id = 2,
                            Address = "Aerodrom",
                            FullName = "Tom Kruz",
                            IsDelivered = true,
                            LocationId = 1
                        },
                        new
                        {
                            Id = 3,
                            Address = "Karposh 3",
                            FullName = "Marjanka Marievska",
                            IsDelivered = true,
                            LocationId = 3
                        },
                        new
                        {
                            Id = 4,
                            Address = "Idrizovo zatvor",
                            FullName = "Yugo Kostov",
                            IsDelivered = false,
                            LocationId = 1
                        },
                        new
                        {
                            Id = 5,
                            Address = "Taftalidze",
                            FullName = "Petre Petkov",
                            IsDelivered = false,
                            LocationId = 3
                        });
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.BurgerOrder", b =>
                {
                    b.HasOne("BurgerApp.Domain.Models.Burger", "Burger")
                        .WithMany("BurgerOrders")
                        .HasForeignKey("BurgerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerApp.Domain.Models.Order", "Order")
                        .WithMany("BurgerOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Burger");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Order", b =>
                {
                    b.HasOne("BurgerApp.Domain.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Burger", b =>
                {
                    b.Navigation("BurgerOrders");
                });

            modelBuilder.Entity("BurgerApp.Domain.Models.Order", b =>
                {
                    b.Navigation("BurgerOrders");
                });
#pragma warning restore 612, 618
        }
    }
}