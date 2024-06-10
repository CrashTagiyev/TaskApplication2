using ProductCommandMicroservice.Entity;

namespace ProductCommandMicroservice.Repositories
{
	public interface IProductCommandRepository
	{
		Task AddProduct(Product product);
		Task DeleteProduct(int id);
		Task UpdateProduct(Product product);
	}
}
