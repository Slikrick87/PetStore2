
using Microsoft.EntityFrameworkCore;
using PetStore;
using PetStore.Data.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace PetStore.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }


        public string DbPath { get; }

        //private readonly ProductContext _context;
        public ProductContext(DbContextOptions<ProductContext> options)
                : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Product.db");

        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlite($"Data Source={DbPath}");
            }
            options.UseSqlite($"Data Source={DbPath}");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER")
                      .IsRequired();
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasColumnType("TEXT");
                entity.Property(e => e.Price)
                      .IsRequired()
                      .HasColumnType("TEXT");
                entity.Property(e => e.Quantity)
                      .IsRequired()
                      .HasColumnType("INTEGER");
                entity.Property(e => e.Description)
                      .IsRequired()
                      .HasColumnType("TEXT");
            });
            modelBuilder.Entity<OrderEntity>(Entity =>
            {
                Entity.HasKey(e => e.OrderId);
                Entity.Property(e => e.OrderId)
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER")
                      .IsRequired();
                Entity.Property(e => e.OrderDate)
                      .IsRequired()
                      .HasColumnType("TEXT");
                Entity.Property(e => e.Products)
                      .IsRequired()
                      .HasColumnType("TEXT");
            });
        }
    }
}

