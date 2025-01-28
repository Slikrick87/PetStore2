
using Microsoft.EntityFrameworkCore;
using PetStore;
using static System.Net.Mime.MediaTypeNames;

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
        {
            if (!options.IsConfigured)
            {
                options.UseSqlite($"Data Source={DbPath}");
            }
            options.UseSqlite($"Data Source={DbPath}");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProductEntity>().ToTable("Products");
        //    modelBuilder.Entity<DogLeashEntity>().ToTable("DogLeashes");
        //    modelBuilder.Entity<CatFoodEntity>().ToTable("CatFoods");
        //}

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

            modelBuilder.Entity<CatFoodEntity>(entity =>
            {
                entity.HasBaseType<ProductEntity>();
                entity.Property(e => e.KittenFood)
                      .HasColumnType("INTEGER");
            });

            modelBuilder.Entity<DogLeashEntity>(entity =>
            {
                entity.HasBaseType<ProductEntity>();
                entity.Property(e => e.LengthInches)
                      .HasColumnType("INTEGER");
                entity.Property(e => e.Material)
                      .HasColumnType("TEXT");
            });
        }
    }
}

