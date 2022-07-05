﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantAPI2.Data;

#nullable disable

namespace RestaurantAPI2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220630122659_Second_Migration")]
    partial class Second_Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BranchDish", b =>
                {
                    b.Property<int>("branchesbranchID")
                        .HasColumnType("int");

                    b.Property<int>("dishesdishID")
                        .HasColumnType("int");

                    b.HasKey("branchesbranchID", "dishesdishID");

                    b.HasIndex("dishesdishID");

                    b.ToTable("BranchDish");
                });

            modelBuilder.Entity("DishOrder", b =>
                {
                    b.Property<int>("dishesdishID")
                        .HasColumnType("int");

                    b.Property<int>("ordersorderID")
                        .HasColumnType("int");

                    b.HasKey("dishesdishID", "ordersorderID");

                    b.HasIndex("ordersorderID");

                    b.ToTable("DishOrder");
                });

            modelBuilder.Entity("RestaurantAPI2.Models.Branch", b =>
                {
                    b.Property<int>("branchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("branchID"), 1L, 1);

                    b.Property<string>("branchCityName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("branchTelephone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("branchTotalEmployees")
                        .HasColumnType("int");

                    b.Property<int>("ownerID")
                        .HasColumnType("int");

                    b.HasKey("branchID");

                    b.HasIndex("ownerID");

                    b.ToTable("branches");
                });

            modelBuilder.Entity("RestaurantAPI2.Models.Customer", b =>
                {
                    b.Property<int>("customerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("customerID"), 1L, 1);

                    b.Property<string>("customerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("customerPhone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("orderID")
                        .HasColumnType("int");

                    b.HasKey("customerID");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("RestaurantAPI2.Models.Dish", b =>
                {
                    b.Property<int>("dishID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("dishID"), 1L, 1);

                    b.Property<int>("branchID")
                        .HasColumnType("int");

                    b.Property<string>("dishIngredient")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("dishName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("dishPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("orderID")
                        .HasColumnType("int");

                    b.HasKey("dishID");

                    b.ToTable("dishes");
                });

            modelBuilder.Entity("RestaurantAPI2.Models.Employee", b =>
                {
                    b.Property<int>("empID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("empID"), 1L, 1);

                    b.Property<int?>("branchID")
                        .HasColumnType("int");

                    b.Property<string>("empName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("empRoll")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("empID");

                    b.HasIndex("branchID");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("RestaurantAPI2.Models.Order", b =>
                {
                    b.Property<int>("orderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("orderID"), 1L, 1);

                    b.Property<int?>("customerID")
                        .HasColumnType("int");

                    b.Property<int>("dishID")
                        .HasColumnType("int");

                    b.Property<string>("orderDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("orderPrice")
                        .HasColumnType("int");

                    b.Property<string>("orderTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("orderID");

                    b.HasIndex("customerID");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("RestaurantAPI2.Models.Owner", b =>
                {
                    b.Property<int>("ownerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ownerID"), 1L, 1);

                    b.Property<string>("ownerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ownerPhone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("ownerID");

                    b.ToTable("owner");
                });

            modelBuilder.Entity("RestaurantAPI2.Models.Restaurant", b =>
                {
                    b.Property<int>("restaurantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("restaurantID"), 1L, 1);

                    b.Property<string>("restaurantName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("restaurantType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("restaurationLocation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("restaurantID");

                    b.ToTable("restaurants");
                });

            modelBuilder.Entity("RestaurantAPI2.Models.Users", b =>
                {
                    b.Property<string>("Userid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Userid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BranchDish", b =>
                {
                    b.HasOne("RestaurantAPI2.Models.Branch", null)
                        .WithMany()
                        .HasForeignKey("branchesbranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI2.Models.Dish", null)
                        .WithMany()
                        .HasForeignKey("dishesdishID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DishOrder", b =>
                {
                    b.HasOne("RestaurantAPI2.Models.Dish", null)
                        .WithMany()
                        .HasForeignKey("dishesdishID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI2.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("ordersorderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantAPI2.Models.Branch", b =>
                {
                    b.HasOne("RestaurantAPI2.Models.Owner", "owner")
                        .WithMany()
                        .HasForeignKey("ownerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("owner");
                });

            modelBuilder.Entity("RestaurantAPI2.Models.Employee", b =>
                {
                    b.HasOne("RestaurantAPI2.Models.Branch", null)
                        .WithMany("employees")
                        .HasForeignKey("branchID");
                });

            modelBuilder.Entity("RestaurantAPI2.Models.Order", b =>
                {
                    b.HasOne("RestaurantAPI2.Models.Customer", null)
                        .WithMany("orders")
                        .HasForeignKey("customerID");
                });

            modelBuilder.Entity("RestaurantAPI2.Models.Branch", b =>
                {
                    b.Navigation("employees");
                });

            modelBuilder.Entity("RestaurantAPI2.Models.Customer", b =>
                {
                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
