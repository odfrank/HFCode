﻿// <auto-generated />
using System;
using HFApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HFApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.6.23329.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HFApp.Models.BinLookup", b =>
                {
                    b.Property<int>("BinLookupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BinLookupId"));

                    b.Property<string>("BinNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("BinLookupId");

                    b.ToTable("BinLookup");

                    b.HasData(
                        new
                        {
                            BinLookupId = 1,
                            BinNumber = "T345",
                            Description = "Large bin",
                            Height = 10,
                            Length = 10,
                            Location = "Row 2, Slot 1",
                            Width = 50
                        },
                        new
                        {
                            BinLookupId = 2,
                            BinNumber = "T5789",
                            Description = "Small bin",
                            Height = 5,
                            Length = 5,
                            Location = "Row 1, Slot 1",
                            Width = 25
                        },
                        new
                        {
                            BinLookupId = 3,
                            BinNumber = "T9876",
                            Description = "Large bin",
                            Height = 10,
                            Length = 10,
                            Location = "Row 3, Slot 2",
                            Width = 50
                        },
                        new
                        {
                            BinLookupId = 4,
                            BinNumber = "T098",
                            Description = "Medium bin",
                            Height = 7,
                            Length = 10,
                            Location = "Row 3, Slot 1",
                            Width = 30
                        },
                        new
                        {
                            BinLookupId = 5,
                            BinNumber = "T349",
                            Description = "Small bin",
                            Height = 5,
                            Length = 5,
                            Location = "Row 1, Slot 2",
                            Width = 25
                        },
                        new
                        {
                            BinLookupId = 6,
                            BinNumber = "T5789",
                            Description = "Large bin",
                            Height = 10,
                            Length = 10,
                            Location = "Row 4, Slot 5",
                            Width = 50
                        },
                        new
                        {
                            BinLookupId = 7,
                            BinNumber = "T9875",
                            Description = "Large bin",
                            Height = 10,
                            Length = 10,
                            Location = "Row 2, Slot 2",
                            Width = 50
                        });
                });

            modelBuilder.Entity("HFApp.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<string>("FaxNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("FacilityId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "12 Beacon St",
                            City = "Boston",
                            CompanyName = "Adatum Corporation",
                            ContactTitle = "Manager",
                            Country = "USA",
                            CustomerName = "Adrian King",
                            Email = "adrian@example.com",
                            FacilityId = 1,
                            FaxNumber = "(123) 555-0124",
                            PhoneNumber = "(123) 555-0134",
                            State = "MA",
                            ZipCode = "98765"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "123 Main Street",
                            City = "Seattle",
                            CompanyName = "Adventure Works",
                            ContactTitle = "Sr. Buyer",
                            Country = "USA",
                            CustomerName = "Aidyn Zhanbolat",
                            Email = "aidyn@example.com",
                            FacilityId = 2,
                            FaxNumber = "(456) 555-0146",
                            PhoneNumber = "(456) 555-0145",
                            State = "WA",
                            ZipCode = "87654"
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "321 Avenue A",
                            City = "Portland",
                            CompanyName = "Alpine Ski House",
                            ContactTitle = "Analyst",
                            Country = "USA",
                            CustomerName = "Alex Krejci",
                            Email = "alex@example.com",
                            FacilityId = 3,
                            FaxNumber = "(212) 555-0102",
                            PhoneNumber = "(212) 555-0101",
                            State = "OR",
                            ZipCode = "76543"
                        },
                        new
                        {
                            CustomerId = 4,
                            Address = "89 Pacific Ave",
                            City = "San Francisco",
                            CompanyName = "Adventure Works",
                            ContactTitle = "Managing Partner",
                            Country = "USA",
                            CustomerName = "Alix Gauthier",
                            Email = "alix@example.com",
                            FacilityId = 4,
                            FaxNumber = "(786) 555-0151",
                            PhoneNumber = "(786) 555-0150",
                            State = "CA",
                            ZipCode = "65432"
                        });
                });

            modelBuilder.Entity("HFApp.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HFApp.Models.EmployeeFacility", b =>
                {
                    b.Property<int>("EmployeeFacilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeFacilityId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeFacilityId");

                    b.ToTable("EmployeeFacilities");
                });

            modelBuilder.Entity("HFApp.Models.Facility", b =>
                {
                    b.Property<int>("FacilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacilityId"));

                    b.Property<string>("FacilityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacilityId");

                    b.ToTable("Facilities");

                    b.HasData(
                        new
                        {
                            FacilityId = 1,
                            FacilityName = "AbujaStore",
                            Location = "Abuja, Nigeria"
                        },
                        new
                        {
                            FacilityId = 2,
                            FacilityName = "LagosStore",
                            Location = "Lagos, Nigeria"
                        },
                        new
                        {
                            FacilityId = 3,
                            FacilityName = "TexasStore",
                            Location = "Texas, USA"
                        },
                        new
                        {
                            FacilityId = 4,
                            FacilityName = "AccraStore",
                            Location = "Accra, Ghana"
                        });
                });

            modelBuilder.Entity("HFApp.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryId"));

                    b.Property<int>("BinLookupId")
                        .HasColumnType("int");

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("HFApp.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Price = 30m,
                            ProductDescription = "Item 1",
                            ProductName = "Item 1"
                        },
                        new
                        {
                            ProductId = 2,
                            Price = 40m,
                            ProductDescription = "Item 2",
                            ProductName = "Item 2"
                        },
                        new
                        {
                            ProductId = 3,
                            Price = 5m,
                            ProductDescription = "Item 3",
                            ProductName = "Item 3"
                        },
                        new
                        {
                            ProductId = 4,
                            Price = 15m,
                            ProductDescription = "Item 4",
                            ProductName = "Item 4"
                        },
                        new
                        {
                            ProductId = 5,
                            Price = 26m,
                            ProductDescription = "Item 5",
                            ProductName = "Item 5"
                        },
                        new
                        {
                            ProductId = 6,
                            Price = 50m,
                            ProductDescription = "Item 6",
                            ProductName = "Item 6"
                        },
                        new
                        {
                            ProductId = 7,
                            Price = 10m,
                            ProductDescription = "Item 7",
                            ProductName = "Item 7"
                        },
                        new
                        {
                            ProductId = 8,
                            Price = 3m,
                            ProductDescription = "Item 8",
                            ProductName = "Item 8"
                        },
                        new
                        {
                            ProductId = 9,
                            Price = 14m,
                            ProductDescription = "Item 9",
                            ProductName = "Item 9"
                        },
                        new
                        {
                            ProductId = 10,
                            Price = 60m,
                            ProductDescription = "Item 10",
                            ProductName = "Item 10"
                        },
                        new
                        {
                            ProductId = 11,
                            Price = 8m,
                            ProductDescription = "Item 11",
                            ProductName = "Item 11"
                        });
                });

            modelBuilder.Entity("HFApp.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SaleId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("HFApp.Models.SaleDetails", b =>
                {
                    b.Property<int>("SaleDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleDetailsId"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("QuantitySold")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("SaleDetailsId");

                    b.ToTable("SaleDetails");
                });

            modelBuilder.Entity("HFApp.Models.Customer", b =>
                {
                    b.HasOne("HFApp.Models.Facility", "Facility")
                        .WithMany()
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facility");
                });
#pragma warning restore 612, 618
        }
    }
}
