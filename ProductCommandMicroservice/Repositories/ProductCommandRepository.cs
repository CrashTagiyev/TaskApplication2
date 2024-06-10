using Microsoft.EntityFrameworkCore;
using ProductCommandMicroservice.AppDbContext;
using ProductCommandMicroservice.Entity;

namespace ProductCommandMicroservice.Repositories
{
	public class ProductCommandRepository : IProductCommandRepository
	{
		private readonly CommandDBContext _context;

		public ProductCommandRepository(CommandDBContext context)
		{
			_context = context;
		}

		async Task IProductCommandRepository.AddProduct(Product product)
		{
			 _context.Add(product!);
			_context.SaveChanges();
		}

		async Task IProductCommandRepository.DeleteProduct(int id)
		{
			var product =await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
			_context.Products.Remove(product!);
			_context.SaveChanges();
		}

		Task IProductCommandRepository.UpdateProduct(Product product)
		{
			throw new NotImplementedException();
		}
	}
}
