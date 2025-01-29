using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PetStore.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        //public DbSet<DogLeashEntity> DogLeashes { get; set; }
        //public DbSet<CatFoodEntity> CatFoods { get; set; }

        public string DbPath { get; }

        public ProductContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Combine(path, "PetStore.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }
    }
}
