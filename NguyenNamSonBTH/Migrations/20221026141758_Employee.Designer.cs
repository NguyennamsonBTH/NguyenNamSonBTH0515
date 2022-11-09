﻿// <auto-generated />
using System;
using NguyenNamSonBTH515.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace NguyenNamSonBTH515.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20221026141758_Employee")]
    partial class Employee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("NguyenNamSonBTH515.Models.Customer", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaKH")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SĐT")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("NguyenNamSonBTH515.Models.Employee", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("NguyenNamSonBTH515.Models.Person", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Personname")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("NguyenNamSonBTH515.Models.Student", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentAge")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}