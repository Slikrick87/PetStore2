using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Validators
{
    public class DogLeashValidator : AbstractValidator<DogLeash>
    {
        public DogLeashValidator() 
        {
            RuleFor(dogleash => dogleash.Name).NotNull();
            RuleFor(dogleash => dogleash.Price).GreaterThanOrEqualTo(0);
            RuleFor(dogleash => dogleash.Quantity).GreaterThanOrEqualTo(0);
            RuleFor(dogleash => dogleash.Description).MaximumLength(15);

        }
    }
}
