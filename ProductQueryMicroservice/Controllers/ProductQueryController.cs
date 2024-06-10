using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductQueryMicroservice.Repositories;

namespace ProductQueryMicroservice.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductQueryController : ControllerBase
	{
		private readonly IProductQueryRepository _repository;
		public ProductQueryController(IProductQueryRepository repository)
		{
			_repository = repository;
		}

		[HttpGet("getproduct/{id?}")]
		public async Task<IActionResult> GetProduct(int id) {

			var product= await _repository.GetProduct(id);
			return Ok();
		}


		[HttpGet("[action]")]
		public async Task<IActionResult> GetALlProducts()
		{

			return Ok(await _repository.GetProducts());
		}

	}


}
