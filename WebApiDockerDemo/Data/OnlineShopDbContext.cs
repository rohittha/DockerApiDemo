using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using WebApiDockerDemo.Models;

namespace WebApiDockerDemo.Data
{
    public class OnlineShopDbContext: DbContext
    {
        public OnlineShopDbContext(DbContextOptions<OnlineShopDbContext> options) : base(options)
        {
            var dbCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
            if(dbCreator != null)
            {
                if (!dbCreator.CanConnect())
                {
                    dbCreator.Create();
                }

                if (!dbCreator.HasTables())
                {
                    dbCreator.CreateTables();
                }
            }
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Apple Ipad", Price = 1000 },
                new Product() { Id = 2, Name = "Samsung Smart TV", Price = 850 },
                new Product() { Id = 3, Name = "Nokia N95", Price = 1200 }
                );
        }
    }
}
