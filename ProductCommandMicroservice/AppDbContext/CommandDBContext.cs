using Microsoft.EntityFrameworkCore;
using ProductCommandMicroservice.Entity;

namespace ProductCommandMicroservice.AppDbContext
{
	public class CommandDBContext:DbContext
	{
        public CommandDBContext(DbContextOptions<CommandDBContext> options)
            :base(options)
        {
            
        }

      public  DbSet<Product> Products { get; set; }
    }
}
