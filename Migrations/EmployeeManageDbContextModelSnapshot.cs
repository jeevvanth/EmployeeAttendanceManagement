﻿// <auto-generated />
using System;
using EmployeeAttendanceManagement.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeAttendanceManagement.Migrations
{
    [DbContext(typeof(EmployeeManageDbContext))]
    partial class EmployeeManageDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeAttendanceManagement.Models.Attendance", b =>
                {
                    b.Property<int>("Attendace_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Attendace_Id"));

                    b.Property<DateTime>("Attendance_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Check_in")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Check_out")
                        .HasColumnType("datetime2");

                    b.Property<int>("Employee_Id")
                        .HasColumnType("int");

                    b.HasKey("Attendace_Id");

                    b.ToTable("attendance");
                });

            modelBuilder.Entity("EmployeeAttendanceManagement.Models.Employee", b =>
                {
                    b.Property<int>("Employee_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Employee_Id"));

                    b.Property<string>("Employee_Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employee_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employee_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Employee_Id");

                    b.ToTable("employee");
                });
#pragma warning restore 612, 618
        }
    }
}
