using Microsoft.EntityFrameworkCore;
using PetStore;

namespace PetStore.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<DogLeashEntity> DogLeashes { get; set; }
        public DbSet<CatFoodEntity> CatFoods { get; set; }


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
            => options.UseSqlite($"Data Source={DbPath}");

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProductEntity>().ToTable("Products");
        //    modelBuilder.Entity<DogLeashEntity>().ToTable("DogLeashes");
        //    modelBuilder.Entity<CatFoodEntity>().ToTable("CatFoods");
        //}
    }
}
