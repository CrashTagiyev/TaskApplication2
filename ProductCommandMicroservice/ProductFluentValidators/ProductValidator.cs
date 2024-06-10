using FluentValidation;
using ProductCommandMicroservice.Entity;

namespace ProductCommandMicroservice.ProductFluentValidators
{
	public class ProductValidator:AbstractValidator<Product>
	{
        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).NotEmpty().NotNull();
            RuleFor(p=>p.Price).NotEmpty().NotNull();
		}
    }
}
