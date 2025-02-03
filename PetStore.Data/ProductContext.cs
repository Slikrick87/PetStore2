
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PetStore;
using PetStore.Data;
using static System.Net.Mime.MediaTypeNames;

namespace PetStore.Data
{
    public class ProductContext : DbContext
    {
        public string DbPath { get; }

        //private readonly ProductContext _context;
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "PetStore.db");

        }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)

            => options.UseSqlite($"Data Source={DbPath}");
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProductEntity>()
        //        .
        //        .ToTable("Products")
        //        .HasKey(p => p.Id);
                
                
        //}



        //}
    }
}

