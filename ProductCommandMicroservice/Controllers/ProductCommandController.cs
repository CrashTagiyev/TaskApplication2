using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCommandMicroservice.Entity;
using ProductCommandMicroservice.Repositories;

namespace ProductCommandMicroservice.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductCommandController : ControllerBase
	{
		private readonly IProductCommandRepository _repository;

		public ProductCommandController(IProductCommandRepository repository)
		{
			_repository = repository;
		}

		[HttpPost("[action]")]
		public IActionResult AddProduct(Product product)
		{
			if(!ModelState.IsValid)
				return BadRequest(product);
			_repository.AddProduct(product);
			return Ok("Product added");
		}
		[HttpPost("[action]")]
		public async Task<IActionResult> DeleteProduct(int id)
		{
		await _repository.DeleteProduct(id);
			return Ok("Product deleted");
		}
	}
}
