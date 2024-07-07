using Microsoft.EntityFrameworkCore;
using MvcCategory.Models.Entity;
using MvcCategory.Models.Entity.Category;

namespace MvcCategory.Data
{
    public class CategoryDbContext : DbContext
    {
        public CategoryDbContext(DbContextOptions<CategoryDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //HasData بتشبه SeedingData 
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Laptop", Description = "laptop" },
                new Category { Id = 2, Name = "Books", Description = "books" },
                new Category { Id = 3, Name = "Accessories", Description = "accessories" }
            );
        }
    }
}

