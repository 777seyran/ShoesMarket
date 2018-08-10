using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesMarket.Models
{
    public class ShoesAppDbContext:DbContext
    {
        public ShoesAppDbContext(DbContextOptions<ShoesAppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Delievery> Delieveries { get; set; }
        public DbSet<DeliveryType> DeliveryTypes { get; set; }
        public DbSet<DeliveryStatus> DeliveryStatuses{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
               .Property(p => p.Discount).HasColumnType("decimal(5,2)").IsRequired(true);
        }

    }
}
