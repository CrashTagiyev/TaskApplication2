using Microsoft.EntityFrameworkCore;
using ProductQueryMicroservice.Entity;
using ProductQueryMicroservice.QueryDbContext;

namespace ProductQueryMicroservice.Repositories
{
	public class ProductQueryRepository : IProductQueryRepository
	{
		private readonly ProductQuerryDbContext _context;
		public ProductQueryRepository(ProductQuerryDbContext context)
		{
			_context = context;
		}
		public async Task<Product> GetProduct(int id)
		{
			return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<ICollection<Product>> GetProducts()
		{
			return await _context.Products.ToListAsync();
		}
	}
}
