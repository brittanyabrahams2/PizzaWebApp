﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaOrderingAPI.Models;

namespace PizzaOrderingAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190730024408_6")]
    partial class _6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.CheeseAmount", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Amount");

                    b.Property<double>("Price");

                    b.HasKey("id");

                    b.ToTable("CheeseAmount");
                });

            modelBuilder.Entity("Entities.Crust", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CrustName");

                    b.Property<double>("Price");

                    b.HasKey("id");

                    b.ToTable("Crust");
                });

            modelBuilder.Entity("Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNo");

                    b.Property<string>("State");

                    b.Property<string>("Username");

                    b.Property<string>("Zip");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<bool>("IsDelivered");

                    b.Property<DateTime>("OrderDate");

                    b.Property<double>("Price");

                    b.HasKey("OrderId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Entities.Payment", b =>
                {
                    b.Property<string>("CardNo")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("CVV");

                    b.Property<int>("CustomerId");

                    b.Property<string>("ExpirationDate");

                    b.HasKey("CardNo");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Entities.Pizza", b =>
                {
                    b.Property<int>("PizzaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CheeseAmountId");

                    b.Property<int>("CrustId");

                    b.Property<int>("OrderId");

                    b.Property<double>("Price");

                    b.Property<int>("SauceAmountId");

                    b.Property<int>("SauceId");

                    b.Property<int>("SizeId");

                    b.Property<int?>("Topping1");

                    b.Property<int?>("Topping2");

                    b.Property<int?>("Topping3");

                    b.Property<int?>("Topping4");

                    b.Property<int?>("Topping5");

                    b.Property<int>("ToppingCount");

                    b.HasKey("PizzaId");

                    b.ToTable("Pizza");
                });

            modelBuilder.Entity("Entities.Sauce", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Price");

                    b.Property<string>("SauceName");

                    b.HasKey("id");

                    b.ToTable("Sauce");
                });

            modelBuilder.Entity("Entities.SauceAmount", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Amount");

                    b.Property<double>("Price");

                    b.HasKey("id");

                    b.ToTable("SauceAmount");
                });

            modelBuilder.Entity("Entities.Size", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Price");

                    b.Property<string>("SizeName");

                    b.HasKey("id");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("Entities.Toppping", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ToppingName");

                    b.Property<double>("ToppingPrice");

                    b.HasKey("id");

                    b.ToTable("Topping");
                });
#pragma warning restore 612, 618
        }
    }
}
