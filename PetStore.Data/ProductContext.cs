
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

        //private readonly ProductContext _context;
        public ProductContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "PetStore.db");

        }
        

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
                options.UseSqlite($"Data Source={DbPath}");
            
        }
        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProductEntity>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //    entity.Property(e => e.Id)
        //          .ValueGeneratedOnAdd()
        //          .HasColumnType("INTEGER")
        //          .IsRequired();
        //        entity.Property(e => e.Name)
        //              .IsRequired()
        //              .HasColumnType("TEXT");
        //        entity.Property(e => e.Price)
        //              .IsRequired()
        //              .HasColumnType("Decimal");
        //        entity.Property(e => e.Quantity)
        //              .IsRequired()
        //              .HasColumnType("INTEGER");
        //        entity.Property(e => e.Description)
        //              .IsRequired()
        //              .HasColumnType("TEXT");


        //    });

        //    modelBuilder.Entity<OrderEntity>(entity =>
        //    {
        //        entity.HasKey(e => e.OrderId);
        //        entity.Property(e => e.OrderId)
        //              .ValueGeneratedOnAdd()
        //              .HasColumnType("INTEGER")
        //              .IsRequired();
        //        entity.Property(e => e.OrderDate)
        //              .IsRequired()
        //              .HasColumnType("TEXT");
        //        entity.HasMany(e => e.Products)
        //              .WithOne(p => p.Order)
        //              .HasForeignKey(p => p.OrderId);
        //    });

        }
        
    }


