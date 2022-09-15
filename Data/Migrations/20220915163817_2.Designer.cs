﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bookwormbackend.Data;

#nullable disable

namespace bookwormbackend.Data.Migrations
{
    [DbContext(typeof(BookwormDbContext))]
    [Migration("20220915163817_2")]
    partial class _2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("bookwormbackend.Models.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BooksStockId")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BooksStockId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("bookwormbackend.Models.BooksPurchased", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("bid")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BooksPurchased");
                });

            modelBuilder.Entity("bookwormbackend.Models.BooksRented", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("bid")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BooksRented");
                });

            modelBuilder.Entity("bookwormbackend.Models.BooksStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BooksStock");
                });

            modelBuilder.Entity("bookwormbackend.Models.Invoices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("bids")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("purchaseType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("totalordercost")
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("bookwormbackend.Models.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("bid")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("purchaseType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("bookwormbackend.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BooksPurchasedId")
                        .HasColumnType("int");

                    b.Property<int?>("BooksRentedId")
                        .HasColumnType("int");

                    b.Property<int?>("InvoicesId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderDetailsId")
                        .HasColumnType("int");

                    b.Property<int?>("UserShelfId")
                        .HasColumnType("int");

                    b.Property<int>("bid")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("totalorderprice")
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BooksPurchasedId");

                    b.HasIndex("BooksRentedId");

                    b.HasIndex("InvoicesId");

                    b.HasIndex("OrderDetailsId");

                    b.HasIndex("UserShelfId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("bookwormbackend.Models.UserCreds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserCreds");
                });

            modelBuilder.Entity("bookwormbackend.Models.UserData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("UserCredsId")
                        .HasColumnType("int");

                    b.Property<int?>("UserShelfId")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("wallet")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserCredsId");

                    b.HasIndex("UserShelfId");

                    b.ToTable("UserData");
                });

            modelBuilder.Entity("bookwormbackend.Models.UserShelf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("bid")
                        .HasColumnType("int");

                    b.Property<int?>("booksPurchased")
                        .HasColumnType("int");

                    b.Property<int?>("booksRented")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserShelf");
                });

            modelBuilder.Entity("bookwormbackend.Models.Books", b =>
                {
                    b.HasOne("bookwormbackend.Models.BooksStock", "BooksStock")
                        .WithMany()
                        .HasForeignKey("BooksStockId");

                    b.Navigation("BooksStock");
                });

            modelBuilder.Entity("bookwormbackend.Models.Orders", b =>
                {
                    b.HasOne("bookwormbackend.Models.BooksPurchased", "BooksPurchased")
                        .WithMany()
                        .HasForeignKey("BooksPurchasedId");

                    b.HasOne("bookwormbackend.Models.BooksRented", "BooksRented")
                        .WithMany()
                        .HasForeignKey("BooksRentedId");

                    b.HasOne("bookwormbackend.Models.Invoices", "Invoices")
                        .WithMany()
                        .HasForeignKey("InvoicesId");

                    b.HasOne("bookwormbackend.Models.OrderDetails", "OrderDetails")
                        .WithMany()
                        .HasForeignKey("OrderDetailsId");

                    b.HasOne("bookwormbackend.Models.UserShelf", "UserShelf")
                        .WithMany()
                        .HasForeignKey("UserShelfId");

                    b.Navigation("BooksPurchased");

                    b.Navigation("BooksRented");

                    b.Navigation("Invoices");

                    b.Navigation("OrderDetails");

                    b.Navigation("UserShelf");
                });

            modelBuilder.Entity("bookwormbackend.Models.UserData", b =>
                {
                    b.HasOne("bookwormbackend.Models.UserCreds", "UserCreds")
                        .WithMany()
                        .HasForeignKey("UserCredsId");

                    b.HasOne("bookwormbackend.Models.UserShelf", "UserShelf")
                        .WithMany()
                        .HasForeignKey("UserShelfId");

                    b.Navigation("UserCreds");

                    b.Navigation("UserShelf");
                });
#pragma warning restore 612, 618
        }
    }
}
