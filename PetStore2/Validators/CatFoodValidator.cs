//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using FluentValidation;
//using PetStore.Data;

//namespace PetStore.Validators
//{
//    public class CatFoodValidator : AbstractValidator<CatFoodEntity>
//    {
//        public CatFoodValidator()
//        {
//            RuleFor(catfood => catfood.Name).NotNull();
//            RuleFor(catfood => catfood.Price).GreaterThanOrEqualTo(0);
//            RuleFor(catfood => catfood.Quantity).GreaterThanOrEqualTo(0);
//            RuleFor(catfood => catfood.Description).MaximumLength(15);

//        }
//    }
//}
