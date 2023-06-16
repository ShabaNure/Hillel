using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK15.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Maksym\\Hillel\\LK15\\LK15-DB.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public DbSet<ShopNet> ShopNets { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Item> Item { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Shop>(entity =>
        //    {
        //        entity.HasKey(s => s.ShopId);
        //        entity.ToTable("Shops");
        //        entity.Property(s => s.ShopId);
        //        entity.Property(s => s.ShopName);
        //        entity.Property(s => s.Item);
        //        entity.HasOne(s => s.Item).WithMany(g => g.Shops).HasForeignKey(s => s.ShopId);
        //    });
        //    modelBuilder.Entity<Item>(entity =>
        //    {
        //        entity.HasKey(s => s.ItemId);
        //        entity.ToTable("Items");
        //        entity.Property(s => s.ItemId);
        //        entity.Property(s => s.ItemName);
        //        entity.Property(s => s.Count);
        //        entity.Property(s => s.Shop);
        //        entity.HasOne(s => s.Shop).WithMany(g => g.Items).HasForeignKey(k => k.ItemId);
        //    });
        //    modelBuilder.Entity<ShopNet>(entity =>
        //    {
        //        entity.HasKey(s => s.NetId);
        //        entity.ToTable("ShopsNet");
        //        entity.Property(s => s.NetId);
        //        entity.Property(s => s.NetName);
        //        entity.Property(s => s.Shops);
        //    });

        //}
    }
}
