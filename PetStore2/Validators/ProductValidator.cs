using FluentValidation;
using PetStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Validators
{
    public class ProductValidator : AbstractValidator<ProductEntity>
    {
        public ProductValidator()
        {
            RuleFor(product => product.Name).NotNull();
            RuleFor(product => product.Price).GreaterThanOrEqualTo(0);
            RuleFor(product => product.Quantity).GreaterThanOrEqualTo(0);
            RuleFor(product => product.Description).MaximumLength(15);
        }
    }
}
