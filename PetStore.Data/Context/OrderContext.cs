using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data
{
    public class OrderContext : DbContext
    {
        public string DbPath { get; }
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "PetStore.db");
        }

        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderEntity>()
                .HasMany(o => o.Products)
                .WithOne()
                .HasForeignKey(o => o.OrderId);
        }
        //private static readonly ProductEntity[] SeedProducts =
        //{
        //    new() {Id = Guid.NewGuid(), Name = "Dog Leash", Price = 19.99m, Quantity = 100, Description = "A sturdy leash for your dog."},
        //    new() {Id = Guid.NewGuid(), Name = "Cat Food", Price = 9.99m, Quantity = 200, Description = "High-quality food for your cat."},
        //    new() {Id = Guid.NewGuid(), Name = "Dog Food", Price = 14.99m, Quantity = 150, Description = "Nutritious food for your dog."},
        //    new() {Id = Guid.NewGuid(), Name = "Cat Toy", Price = 5.99m, Quantity = 300, Description = "A fun toy for your cat."},
        //    new() {Id = Guid.NewGuid(), Name = "Dog Bed", Price = 49.99m, Quantity = 50, Description = "A comfortable bed for your dog."}
        //};
    }
}
