﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentAPI.Models;

#nullable disable

namespace PaymentAPI.Migrations
{
    [DbContext(typeof(PaymentDetailContext))]
    [Migration("20240313083256_usser")]
    partial class usser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PaymentAPI.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EmployeeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .IsUnicode(false)
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)");

                    b.Property<DateTime>("HireDate")
                        .IsUnicode(false)
                        .HasColumnType("datetime2");

                    b.Property<string>("JobTitle")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LoginID")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("MaritalStatus")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)");

                    b.Property<DateTime>("ModifiedDate")
                        .IsUnicode(false)
                        .HasColumnType("datetime2");

                    b.Property<string>("NationalIDNumber")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<Guid?>("RowGuid")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("uniqueidentifier");

                    b.Property<short>("SickLeaveHours")
                        .IsUnicode(false)
                        .HasColumnType("smallint");

                    b.Property<short>("VacationHours")
                        .IsUnicode(false)
                        .HasColumnType("smallint");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("PaymentAPI.Models.PaymentDetail", b =>
                {
                    b.Property<int>("PaymentDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentDetailId"), 1L, 1);

                    b.Property<string>("CarNumber")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CardOwenName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ExpirationDate")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("SecurityCode")
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("PaymentDetailId");

                    b.ToTable("PaymentDetails");
                });

            modelBuilder.Entity("PaymentAPI.Models.UserInfo", b =>
                {
                    b.Property<DateTime?>("CreatedDate")
                        .IsUnicode(false)
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.Property<string>("UserName")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.ToTable("UserInfo", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
