﻿// <auto-generated />
using System;
using ComputersDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComputersDB.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20241107195811_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("ComputersDB.Models.Computer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("InventoryNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameModel")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Services")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Workability")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.HasIndex("UserId");

                    b.ToTable("Computer");
                });

            modelBuilder.Entity("ComputersDB.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("OfficeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("ComputersDB.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("NumberRoom")
                        .HasColumnType("TEXT");

                    b.Property<int?>("departmentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("departmentId");

                    b.ToTable("Office");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ComputerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("OfficeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("departmentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.HasIndex("departmentId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ComputersDB.Models.Computer", b =>
                {
                    b.HasOne("ComputersDB.Models.Office", null)
                        .WithMany("Computers")
                        .HasForeignKey("OfficeId");

                    b.HasOne("User", "User")
                        .WithMany("Computers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ComputersDB.Models.Office", b =>
                {
                    b.HasOne("ComputersDB.Models.Department", "department")
                        .WithMany("offices")
                        .HasForeignKey("departmentId");

                    b.Navigation("department");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.HasOne("ComputersDB.Models.Office", "Office")
                        .WithMany("Users")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComputersDB.Models.Department", "department")
                        .WithMany("Users")
                        .HasForeignKey("departmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");

                    b.Navigation("department");
                });

            modelBuilder.Entity("ComputersDB.Models.Department", b =>
                {
                    b.Navigation("Users");

                    b.Navigation("offices");
                });

            modelBuilder.Entity("ComputersDB.Models.Office", b =>
                {
                    b.Navigation("Computers");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Navigation("Computers");
                });
#pragma warning restore 612, 618
        }
    }
}