﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL.Data;

#nullable disable

namespace _1_DAL.Migrations
{
    [DbContext(typeof(ShopClothesContext))]
    partial class ShopClothesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1_DAL.Models.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Create_Date")
                        .HasColumnType("datetime")
                        .HasColumnName("Create_Date");

                    b.Property<Guid>("Customer_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Des");

                    b.Property<string>("Discount")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Discount");

                    b.Property<string>("MaHD")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaHD");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("product name");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("Status");

                    b.Property<double>("Total")
                        .HasColumnType("float")
                        .HasColumnName("Total");

                    b.Property<Guid>("User_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Voucher_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Customer_Id");

                    b.HasIndex("User_Id");

                    b.HasIndex("Voucher_Id");

                    b.ToTable("Bill", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.BillDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Bill_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Image");

                    b.Property<string>("MaHDCT")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Mahdct");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal")
                        .HasColumnName("Price");

                    b.Property<Guid>("Pro_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal")
                        .HasColumnName("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("Bill_Id");

                    b.HasIndex("Pro_Id");

                    b.ToTable("BillDetail", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.Color", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Color", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CustomerId");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("PurchaseHistory")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Cate_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Color_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)")
                        .HasColumnName("Description");

                    b.Property<string>("MaSp")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Masp");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(38,17)")
                        .HasColumnName("Price");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("Quantity");

                    b.Property<Guid>("Size_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Status");

                    b.Property<Guid>("Supplier_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Cate_Id");

                    b.HasIndex("Color_Id");

                    b.HasIndex("Size_Id");

                    b.HasIndex("Supplier_Id");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenCV");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.Size", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Size", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.Supplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Supplier", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Email");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("PassWord");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("UserName");

                    b.Property<Guid>("role_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("role_Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.Voucher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Create_Date")
                        .HasColumnType("datetime")
                        .HasColumnName("Create_Date");

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("datetime")
                        .HasColumnName("End_Date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<decimal>("Status")
                        .HasColumnType("decimal")
                        .HasColumnName("Status");

                    b.Property<decimal>("Voucher_Percent")
                        .HasColumnType("decimal(38,17)")
                        .HasColumnName("Voucher_Percent");

                    b.HasKey("Id");

                    b.ToTable("Voucher", (string)null);
                });

            modelBuilder.Entity("_1_DAL.Models.Bill", b =>
                {
                    b.HasOne("_1_DAL.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("Customer_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.Voucher", "Voucher")
                        .WithMany()
                        .HasForeignKey("Voucher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Voucher");

                    b.Navigation("customer");
                });

            modelBuilder.Entity("_1_DAL.Models.BillDetail", b =>
                {
                    b.HasOne("_1_DAL.Models.Bill", "Bill")
                        .WithMany()
                        .HasForeignKey("Bill_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("Pro_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("_1_DAL.Models.Product", b =>
                {
                    b.HasOne("_1_DAL.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Cate_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("Color_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("Size_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("Supplier_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Color");

                    b.Navigation("Size");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("_1_DAL.Models.User", b =>
                {
                    b.HasOne("_1_DAL.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("role_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
