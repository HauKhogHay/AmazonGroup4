﻿// <auto-generated />
using Amazon.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Amazon.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Amazon.Models.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            ColorId = 1,
                            ColorName = "White"
                        },
                        new
                        {
                            ColorId = 2,
                            ColorName = "Black"
                        },
                        new
                        {
                            ColorId = 3,
                            ColorName = "Yellow"
                        },
                        new
                        {
                            ColorId = 4,
                            ColorName = "Green"
                        },
                        new
                        {
                            ColorId = 5,
                            ColorName = "Blue"
                        });
                });

            modelBuilder.Entity("Amazon.Models.Sanpham", b =>
                {
                    b.Property<int>("SanphamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<double>("GiaSP")
                        .HasColumnType("float");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSP")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SanphamId");

                    b.HasIndex("ColorId");

                    b.ToTable("Sanphams");

                    b.HasData(
                        new
                        {
                            SanphamId = 1,
                            ColorId = 1,
                            GiaSP = 150000.0,
                            PhotoPath = "images/sp1.png",
                            TenSP = "Maý tính"
                        },
                        new
                        {
                            SanphamId = 2,
                            ColorId = 2,
                            GiaSP = 150000.0,
                            PhotoPath = "images/sp2.png",
                            TenSP = "Điện thoại"
                        },
                        new
                        {
                            SanphamId = 3,
                            ColorId = 3,
                            GiaSP = 150000.0,
                            PhotoPath = "images/sp3.png",
                            TenSP = "Maý tính"
                        },
                        new
                        {
                            SanphamId = 4,
                            ColorId = 4,
                            GiaSP = 150000.0,
                            PhotoPath = "images/sp4.png",
                            TenSP = "Maý tính"
                        },
                        new
                        {
                            SanphamId = 5,
                            ColorId = 5,
                            GiaSP = 0.0,
                            PhotoPath = "images/sp5.png",
                            TenSP = "Maý tính"
                        });
                });

            modelBuilder.Entity("Amazon.Models.Sanpham", b =>
                {
                    b.HasOne("Amazon.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");
                });
#pragma warning restore 612, 618
        }
    }
}