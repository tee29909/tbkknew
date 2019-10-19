﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tbkk.Models;

namespace tbkk.Migrations
{
    [DbContext(typeof(tbkkdbContext))]
    [Migration("20191018163628_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("tbkk.Models.Canteen", b =>
                {
                    b.Property<int>("CanteenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Call")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CanteenID");

                    b.ToTable("Canteen");
                });

            modelBuilder.Entity("tbkk.Models.CarType", b =>
                {
                    b.Property<int>("CarTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyCarID")
                        .HasColumnType("int");

                    b.Property<string>("NameCar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarTypeID");

                    b.HasIndex("CompanyCarID");

                    b.ToTable("CarType");
                });

            modelBuilder.Entity("tbkk.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("tbkk.Models.CompanyCar", b =>
                {
                    b.Property<int>("CompanyCarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Call")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameCompanyCar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyCarID");

                    b.ToTable("CompanyCar");
                });

            modelBuilder.Entity("tbkk.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("tbkk.Models.DetailOT", b =>
                {
                    b.Property<int>("DetailOTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DetailOTID");

                    b.ToTable("DetailOT");
                });

            modelBuilder.Entity("tbkk.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Addr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Call")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Company_CompanyID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Department_DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeType_EmployeeTypeID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Location_LocationID")
                        .HasColumnType("int");

                    b.Property<int>("Position_PositionID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("Company_CompanyID");

                    b.HasIndex("Department_DepartmentID");

                    b.HasIndex("EmployeeType_EmployeeTypeID");

                    b.HasIndex("Location_LocationID");

                    b.HasIndex("Position_PositionID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("tbkk.Models.EmployeeType", b =>
                {
                    b.Property<int>("EmployeeTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeTypeID");

                    b.ToTable("EmployeeType");
                });

            modelBuilder.Entity("tbkk.Models.FoodSet", b =>
                {
                    b.Property<int>("FoodSetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Canteen_CanteenID")
                        .HasColumnType("int");

                    b.Property<string>("FoodSetcoManul")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSet")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FoodSetID");

                    b.HasIndex("Canteen_CanteenID");

                    b.ToTable("FoodSet");
                });

            modelBuilder.Entity("tbkk.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("tbkk.Models.Login", b =>
                {
                    b.Property<int>("LoginID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Employee_EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginID");

                    b.HasIndex("Employee_EmployeeID");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("tbkk.Models.OT", b =>
                {
                    b.Property<int>("OTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("TypStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOT")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OTID");

                    b.ToTable("OT");
                });

            modelBuilder.Entity("tbkk.Models.Part", b =>
                {
                    b.Property<int>("PartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PartID");

                    b.ToTable("Part");
                });

            modelBuilder.Entity("tbkk.Models.Position", b =>
                {
                    b.Property<int>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PositionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionID");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("tbkk.Models.CarType", b =>
                {
                    b.HasOne("tbkk.Models.CompanyCar", "CompanyCar")
                        .WithMany()
                        .HasForeignKey("CompanyCarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tbkk.Models.Employee", b =>
                {
                    b.HasOne("tbkk.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("Company_CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tbkk.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("Department_DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tbkk.Models.EmployeeType", "EmployeeType")
                        .WithMany()
                        .HasForeignKey("EmployeeType_EmployeeTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tbkk.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("Location_LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tbkk.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("Position_PositionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tbkk.Models.FoodSet", b =>
                {
                    b.HasOne("tbkk.Models.Canteen", "Canteen")
                        .WithMany()
                        .HasForeignKey("Canteen_CanteenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tbkk.Models.Login", b =>
                {
                    b.HasOne("tbkk.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("Employee_EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
