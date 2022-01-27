﻿// <auto-generated />
using System;
using HotelverwaltungAPI.Models.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelverwaltungAPI.Migrations
{
    [DbContext(typeof(DbContextHotel))]
    [Migration("20220120154443_test4")]
    partial class test4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("HotelverwaltungAPI.Models.Bill", b =>
                {
                    b.Property<int>("BillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GuestID")
                        .HasColumnType("int");

                    b.Property<bool>("payed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("paymentMethod")
                        .HasColumnType("text");

                    b.Property<DateTime>("paymentTarget")
                        .HasColumnType("datetime");

                    b.HasKey("BillID");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("HotelverwaltungAPI.Models.Guest", b =>
                {
                    b.Property<int>("GuestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Firstname")
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .HasColumnType("text");

                    b.HasKey("GuestID");

                    b.ToTable("Guests");
                });
#pragma warning restore 612, 618
        }
    }
}
