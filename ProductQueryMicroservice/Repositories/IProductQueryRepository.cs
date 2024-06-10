using ProductQueryMicroservice.Entity;

namespace ProductQueryMicroservice.Repositories
{
	public interface IProductQueryRepository
	{
		Task<Product> GetProduct(int id);
		Task<ICollection<Product>> GetProducts();
	}
}
