using Microsoft.EntityFrameworkCore;

namespace SportsPro.Models
{
    public class ProductList : DbContext
    { 
        
       public ProductList(DbContextOptions<ProductList> options)
        : base(options)
    { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Price)
            .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                   Id=1,
                    ProductCode = "TRYNY10",
                    Name = "Tourmanment Master 1.0",
                    Price = (decimal)4.99,
                    ReleaseDate = new DateTime(2018, 12, 1)
                },
                new Product
                {
                    Id=2,
                    ProductCode = "LEAG10",
                    Name = "League Scheduler 1.0",
                    Price = (decimal)7.99,
                    ReleaseDate = new DateTime(2019, 05, 1)

                },
                new Product
                {
                    Id= 3,
                    ProductCode = "DRAFT10",
                    Name = "Draft Manager 1.0",
                    Price = (decimal)4.99,
                    ReleaseDate = new DateTime(2019, 8, 1)
                },
                new Product
                {
                    Id= 4,
                    ProductCode = "TEAM10",
                    Name = "Team Manager 1.0",
                    Price = (decimal)4.99,
                    ReleaseDate = new DateTime(2020, 2, 1)
                },
                new Product
                {
                    Id = 5,
                    ProductCode = "TEAM20",
                    Name = "Tourmanment Master 2.0",
                    Price = (decimal)5.99,
                    ReleaseDate = new DateTime(2021, 02, 15)
                },
                new Product
                {
                    Id = 6,
                    ProductCode = "TRYNY10",
                    Name = "Draft Manager 2.0",
                    Price = (decimal)5.99,
                    ReleaseDate = new DateTime(2022, 07, 15)
                }
                );
        }

    }
}
