using Amazon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Sanpham> Sanphams { get; set; }
        public DbSet<Color> Colors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // 
            modelBuilder.Entity<Sanpham>().HasData(new Sanpham
            {
                SanphamId = 1,
                TenSP = "Hanes Women's EcoSmart Crewneck Sweatshirt",
                GiaSP = 11,
                ColorId = 1,
                PhotoPath = "images/sp1.jpg"
            });

            modelBuilder.Entity<Sanpham>().HasData(new Sanpham
            {
                SanphamId = 2,
                TenSP = "Amazon Essentials Women's Fleece Crewneck Sweatshirt",
                GiaSP = 19,
                ColorId = 2,
                PhotoPath = "images/sp2.jpg"
            });
            modelBuilder.Entity<Sanpham>().HasData(new Sanpham
            {
                SanphamId = 3,
                TenSP = "Hanes Women's EcoSmart Full-Zip Hoodie Sweatshirt",
                GiaSP = 16,
                ColorId = 3,
                PhotoPath = "images/sp3.jpg"
            });

            modelBuilder.Entity<Sanpham>().HasData(new Sanpham
            {
                SanphamId = 4,
                TenSP = "Gildan Women's Fleece Crewneck Sweatshirt, Style G18000fl",
                GiaSP = 12,
                ColorId = 4,
                PhotoPath = "images/sp4.jpg"
            });
            modelBuilder.Entity<Sanpham>().HasData(new Sanpham
            {
                SanphamId = 5,
                TenSP = "Hanes Sport Women's Performance Fleece Pullover Hoodie",
                GiaSP = 17,
                ColorId = 5,
                PhotoPath = "images/sp5.jpg"
            });

            //
            modelBuilder.Entity<Color>().HasData(
                new Color { ColorId = 1, ColorName = "White" });
            modelBuilder.Entity<Color>().HasData(
                new Color { ColorId = 2, ColorName = "Black" });
            modelBuilder.Entity<Color>().HasData(
                new Color { ColorId = 3, ColorName = "Yellow" });
            modelBuilder.Entity<Color>().HasData(
                new Color { ColorId = 4, ColorName = "Green" });
            modelBuilder.Entity<Color>().HasData(
                new Color { ColorId = 5, ColorName = "Blue" });
        }
    }
}
