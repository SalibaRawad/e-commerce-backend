﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using e_commerce_backend.Data;

#nullable disable

namespace e_commerce_backend.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("image")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("discount_percentage")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId")
                        .IsUnique();

                    b.HasIndex("SupplierId")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Whislist", b =>
                {
                    b.Property<int>("WhislistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("WhislistId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Whislists");
                });

            modelBuilder.Entity("WhislistItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("WhislistId")
                        .HasColumnType("int");

                    b.Property<int>("number_of_products")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.HasIndex("WhislistId");

                    b.ToTable("WhislistItem");
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.HasOne("Product", "Product")
                        .WithOne("order")
                        .HasForeignKey("Order", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User", "User")
                        .WithOne("order")
                        .HasForeignKey("Order", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.HasOne("Category", "Category")
                        .WithOne("Product")
                        .HasForeignKey("Product", "CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Supplier", "Supplier")
                        .WithOne("Product")
                        .HasForeignKey("Product", "SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Whislist", b =>
                {
                    b.HasOne("User", "User")
                        .WithOne("whislist")
                        .HasForeignKey("Whislist", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WhislistItem", b =>
                {
                    b.HasOne("Product", "Product")
                        .WithOne("WhislistItem")
                        .HasForeignKey("WhislistItem", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Whislist", "Whislist")
                        .WithMany("WhislistItem")
                        .HasForeignKey("WhislistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Whislist");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.Navigation("WhislistItem");

                    b.Navigation("order");
                });

            modelBuilder.Entity("Supplier", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Navigation("order");

                    b.Navigation("whislist");
                });

            modelBuilder.Entity("Whislist", b =>
                {
                    b.Navigation("WhislistItem");
                });
#pragma warning restore 612, 618
        }
    }
}
