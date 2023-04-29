﻿// <auto-generated />
using InlandMarina.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InlandMarina.Migrations
{
    [DbContext(typeof(InlandMarinaContext))]
    [Migration("20230424231954_UsernamePasswordAdded")]
    partial class UsernamePasswordAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InlandMarina.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            City = "Phoenix",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "password",
                            Phone = "265-555-1212",
                            Username = "jdoe"
                        },
                        new
                        {
                            ID = 2,
                            City = "Calgary",
                            FirstName = "Sara",
                            LastName = "Williams",
                            Password = "password",
                            Phone = "403-555-9585",
                            Username = "swilliams"
                        },
                        new
                        {
                            ID = 3,
                            City = "Kansas City",
                            FirstName = "Ken",
                            LastName = "Wong",
                            Password = "password",
                            Phone = "802-555-3214",
                            Username = "kwong"
                        });
                });

            modelBuilder.Entity("InlandMarina.Models.Dock", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("ElectricalService")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("WaterService")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Docks");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ElectricalService = true,
                            Name = "Dock A",
                            WaterService = true
                        },
                        new
                        {
                            ID = 2,
                            ElectricalService = false,
                            Name = "Dock B",
                            WaterService = true
                        },
                        new
                        {
                            ID = 3,
                            ElectricalService = true,
                            Name = "Dock C",
                            WaterService = false
                        });
                });

            modelBuilder.Entity("InlandMarina.Models.Lease", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("SlipID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("SlipID");

                    b.ToTable("Leases");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CustomerID = 1,
                            SlipID = 20
                        },
                        new
                        {
                            ID = 2,
                            CustomerID = 2,
                            SlipID = 42
                        },
                        new
                        {
                            ID = 3,
                            CustomerID = 3,
                            SlipID = 88
                        });
                });

            modelBuilder.Entity("InlandMarina.Models.Slip", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("DockID")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DockID");

                    b.ToTable("Slips");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DockID = 1,
                            Length = 16,
                            Width = 8
                        },
                        new
                        {
                            ID = 2,
                            DockID = 1,
                            Length = 16,
                            Width = 8
                        },
                        new
                        {
                            ID = 3,
                            DockID = 1,
                            Length = 16,
                            Width = 8
                        },
                        new
                        {
                            ID = 4,
                            DockID = 1,
                            Length = 16,
                            Width = 8
                        },
                        new
                        {
                            ID = 5,
                            DockID = 1,
                            Length = 16,
                            Width = 8
                        },
                        new
                        {
                            ID = 6,
                            DockID = 1,
                            Length = 16,
                            Width = 8
                        },
                        new
                        {
                            ID = 7,
                            DockID = 1,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 8,
                            DockID = 1,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 9,
                            DockID = 1,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 10,
                            DockID = 1,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 11,
                            DockID = 1,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 12,
                            DockID = 1,
                            Length = 22,
                            Width = 8
                        },
                        new
                        {
                            ID = 13,
                            DockID = 1,
                            Length = 22,
                            Width = 8
                        },
                        new
                        {
                            ID = 14,
                            DockID = 1,
                            Length = 22,
                            Width = 8
                        },
                        new
                        {
                            ID = 15,
                            DockID = 1,
                            Length = 22,
                            Width = 8
                        },
                        new
                        {
                            ID = 16,
                            DockID = 1,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 17,
                            DockID = 1,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 18,
                            DockID = 1,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 19,
                            DockID = 1,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 20,
                            DockID = 1,
                            Length = 26,
                            Width = 8
                        },
                        new
                        {
                            ID = 21,
                            DockID = 1,
                            Length = 26,
                            Width = 8
                        },
                        new
                        {
                            ID = 22,
                            DockID = 1,
                            Length = 26,
                            Width = 8
                        },
                        new
                        {
                            ID = 23,
                            DockID = 1,
                            Length = 26,
                            Width = 8
                        },
                        new
                        {
                            ID = 24,
                            DockID = 1,
                            Length = 26,
                            Width = 8
                        },
                        new
                        {
                            ID = 25,
                            DockID = 1,
                            Length = 26,
                            Width = 8
                        },
                        new
                        {
                            ID = 26,
                            DockID = 1,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 27,
                            DockID = 1,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 28,
                            DockID = 1,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 29,
                            DockID = 1,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 30,
                            DockID = 1,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 31,
                            DockID = 2,
                            Length = 18,
                            Width = 8
                        },
                        new
                        {
                            ID = 32,
                            DockID = 2,
                            Length = 18,
                            Width = 8
                        },
                        new
                        {
                            ID = 33,
                            DockID = 2,
                            Length = 18,
                            Width = 8
                        },
                        new
                        {
                            ID = 34,
                            DockID = 2,
                            Length = 18,
                            Width = 8
                        },
                        new
                        {
                            ID = 35,
                            DockID = 2,
                            Length = 18,
                            Width = 8
                        },
                        new
                        {
                            ID = 36,
                            DockID = 2,
                            Length = 18,
                            Width = 8
                        },
                        new
                        {
                            ID = 37,
                            DockID = 2,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 38,
                            DockID = 2,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 39,
                            DockID = 2,
                            Length = 20,
                            Width = 8
                        },
                        new
                        {
                            ID = 40,
                            DockID = 2,
                            Length = 22,
                            Width = 8
                        },
                        new
                        {
                            ID = 41,
                            DockID = 2,
                            Length = 22,
                            Width = 8
                        },
                        new
                        {
                            ID = 42,
                            DockID = 2,
                            Length = 22,
                            Width = 8
                        },
                        new
                        {
                            ID = 43,
                            DockID = 2,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 44,
                            DockID = 2,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 45,
                            DockID = 2,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 46,
                            DockID = 2,
                            Length = 24,
                            Width = 8
                        },
                        new
                        {
                            ID = 47,
                            DockID = 2,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 48,
                            DockID = 2,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 49,
                            DockID = 2,
                            Length = 28,
                            Width = 8
                        },
                        new
                        {
                            ID = 50,
                            DockID = 2,
                            Length = 30,
                            Width = 8
                        },
                        new
                        {
                            ID = 51,
                            DockID = 2,
                            Length = 30,
                            Width = 8
                        },
                        new
                        {
                            ID = 52,
                            DockID = 2,
                            Length = 30,
                            Width = 8
                        },
                        new
                        {
                            ID = 53,
                            DockID = 2,
                            Length = 30,
                            Width = 8
                        },
                        new
                        {
                            ID = 54,
                            DockID = 2,
                            Length = 30,
                            Width = 8
                        },
                        new
                        {
                            ID = 55,
                            DockID = 2,
                            Length = 32,
                            Width = 8
                        },
                        new
                        {
                            ID = 56,
                            DockID = 2,
                            Length = 32,
                            Width = 8
                        },
                        new
                        {
                            ID = 57,
                            DockID = 2,
                            Length = 32,
                            Width = 8
                        },
                        new
                        {
                            ID = 58,
                            DockID = 2,
                            Length = 32,
                            Width = 8
                        },
                        new
                        {
                            ID = 59,
                            DockID = 2,
                            Length = 32,
                            Width = 8
                        },
                        new
                        {
                            ID = 60,
                            DockID = 2,
                            Length = 32,
                            Width = 8
                        },
                        new
                        {
                            ID = 61,
                            DockID = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 62,
                            DockID = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 63,
                            DockID = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 64,
                            DockID = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 65,
                            DockID = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 66,
                            DockID = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 67,
                            DockID = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 68,
                            DockID = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 69,
                            DockID = 3,
                            Length = 22,
                            Width = 10
                        },
                        new
                        {
                            ID = 70,
                            DockID = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 71,
                            DockID = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 72,
                            DockID = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 73,
                            DockID = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 74,
                            DockID = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 75,
                            DockID = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 76,
                            DockID = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 77,
                            DockID = 3,
                            Length = 24,
                            Width = 10
                        },
                        new
                        {
                            ID = 78,
                            DockID = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 79,
                            DockID = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 80,
                            DockID = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 81,
                            DockID = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 82,
                            DockID = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 83,
                            DockID = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 84,
                            DockID = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 85,
                            DockID = 3,
                            Length = 28,
                            Width = 12
                        },
                        new
                        {
                            ID = 86,
                            DockID = 3,
                            Length = 32,
                            Width = 12
                        },
                        new
                        {
                            ID = 87,
                            DockID = 3,
                            Length = 32,
                            Width = 12
                        },
                        new
                        {
                            ID = 88,
                            DockID = 3,
                            Length = 32,
                            Width = 12
                        },
                        new
                        {
                            ID = 89,
                            DockID = 3,
                            Length = 32,
                            Width = 12
                        },
                        new
                        {
                            ID = 90,
                            DockID = 3,
                            Length = 32,
                            Width = 12
                        });
                });

            modelBuilder.Entity("InlandMarina.Models.Lease", b =>
                {
                    b.HasOne("InlandMarina.Models.Customer", "Customer")
                        .WithMany("Leases")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InlandMarina.Models.Slip", "Slip")
                        .WithMany("Leases")
                        .HasForeignKey("SlipID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Slip");
                });

            modelBuilder.Entity("InlandMarina.Models.Slip", b =>
                {
                    b.HasOne("InlandMarina.Models.Dock", "Dock")
                        .WithMany("Slips")
                        .HasForeignKey("DockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dock");
                });

            modelBuilder.Entity("InlandMarina.Models.Customer", b =>
                {
                    b.Navigation("Leases");
                });

            modelBuilder.Entity("InlandMarina.Models.Dock", b =>
                {
                    b.Navigation("Slips");
                });

            modelBuilder.Entity("InlandMarina.Models.Slip", b =>
                {
                    b.Navigation("Leases");
                });
#pragma warning restore 612, 618
        }
    }
}
