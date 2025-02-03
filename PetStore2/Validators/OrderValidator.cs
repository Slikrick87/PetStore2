using FluentValidation;
using PetStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Validators
{
    public class OrderValidator : AbstractValidator<OrderEntity>
    {
        public OrderValidator()
        {
            RuleFor(order => order.OrderDate).NotNull();
        }
    }
}
