﻿// <auto-generated />
using System;
using BackendLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackendLibrary.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20200421073501_ActiveMachineStatus")]
    partial class ActiveMachineStatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BackendLibrary.Models.ActiveMachine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<int>("MachineId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("TimeLeft")
                        .HasColumnType("time(6)");

                    b.HasKey("Id");

                    b.HasIndex("FieldId")
                        .IsUnique();

                    b.HasIndex("MachineId");

                    b.ToTable("ActiveMachines");
                });

            modelBuilder.Entity("BackendLibrary.Models.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("BackendLibrary.Models.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("FieldId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<TimeSpan>("RunTime")
                        .HasColumnType("time(6)");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("BackendLibrary.Models.ActiveMachine", b =>
                {
                    b.HasOne("BackendLibrary.Models.Field", "Field")
                        .WithOne("ActiveMachine")
                        .HasForeignKey("BackendLibrary.Models.ActiveMachine", "FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendLibrary.Models.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BackendLibrary.Models.Machine", b =>
                {
                    b.HasOne("BackendLibrary.Models.Field", "Field")
                        .WithMany()
                        .HasForeignKey("FieldId");
                });
#pragma warning restore 612, 618
        }
    }
}
