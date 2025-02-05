﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniCore_Backend.Data;

#nullable disable

namespace MiniCore_Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241229214707_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("MiniCore_Backend.Models.Departamento", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("MiniCore_Backend.Models.Empleado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("MiniCore_Backend.Models.Gasto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("IDDept")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDEmpleado")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Gastos");
                });
#pragma warning restore 612, 618
        }
    }
}
