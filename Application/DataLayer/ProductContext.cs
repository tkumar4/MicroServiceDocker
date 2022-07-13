using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application.DataLayer.DataObjects;


namespace Application.DataLayer
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Category>().ToTable("Category");


            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    ID = 1,
                    Name = "Electronics",
                    Description = "Electronic Items"
                },
          new Category
          {
              ID = 2,
              Name = "Clothes",
              Description = "Dresses"
          },
          new Category
          {
              ID = 3,
              Name = "Grocery",
              Description = "Grocery Items"
          }
          );
        }
    }
}
