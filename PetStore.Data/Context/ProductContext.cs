
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PetStore;
using PetStore.Data;
using static System.Net.Mime.MediaTypeNames;

namespace PetStore.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public string DbPath { get; }

        public ProductContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "PetStore.db");

        }
        //public DbSet<ProductEntity> Products { get; set; }
        //public DbSet<OrderEntity> Orders { get; set; }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<ProductEntity>(entity =>
            //{
            //    entity.HasKey(e => e.Id);
            //    entity.Property(e => e.Id)
            //          .ValueGeneratedOnAdd()
            //          .HasColumnType("INTEGER")
            //          .IsRequired();
            //    entity.Property(e => e.Name)
            //          .IsRequired()
            //          .HasColumnType("TEXT");
            //    entity.Property(e => e.Price)
            //          .IsRequired()
            //          .HasColumnType("Decimal");
            //    entity.Property(e => e.Quantity)
            //          .IsRequired()
            //          .HasColumnType("INTEGER");
            //    entity.Property(e => e.Description)
            //          .IsRequired()
            //          .HasColumnType("TEXT");


            //});

            //modelBuilder.Entity<OrderEntity>(entity =>
            //{
            //    entity.HasKey(e => e.OrderId);
            //    entity.Property(e => e.OrderId)
            //          .ValueGeneratedOnAdd()
            //          .HasColumnType("INTEGER")
            //          .IsRequired();
            //    entity.Property(e => e.OrderDate)
            //          .IsRequired()
            //          .HasColumnType("TEXT");
            //    entity.HasMany(e => e.Products)
            //          .WithOne(p => p.Order)
            //          .HasForeignKey(p => p.OrderId);
            //});

        }
        //private static readonly ProductEntity[] SeedProducts =
        //{
        //    new() {Id = 1, Name = "Dog Leash", Price = 19.99m, Quantity = 100, Description = "A sturdy leash for your dog."},
        //    new() {Id = 2, Name = "Cat Food", Price = 9.99m, Quantity = 200, Description = "High-quality food for your cat."},
        //    new() {Id = 3, Name = "Dog Food", Price = 14.99m, Quantity = 150, Description = "Nutritious food for your dog."},
        //    new() {Id = 4, Name = "Cat Toy", Price = 5.99m, Quantity = 300, Description = "A fun toy for your cat."},
        //    new() {Id = 5, Name = "Dog Bed", Price = 49.99m, Quantity = 50, Description = "A comfortable bed for your dog."}
        //};
    }
}


