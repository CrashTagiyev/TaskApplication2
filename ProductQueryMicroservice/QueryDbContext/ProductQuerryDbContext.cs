using Microsoft.EntityFrameworkCore;
using ProductQueryMicroservice.Entity;

namespace ProductQueryMicroservice.QueryDbContext
{
	public class ProductQuerryDbContext:DbContext
	{
        public ProductQuerryDbContext(DbContextOptions<ProductQuerryDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

    }
}
