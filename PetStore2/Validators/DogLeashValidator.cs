﻿//using FluentValidation;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using PetStore.Data;

//namespace PetStore.Validators
//{
//    public class DogLeashValidator : AbstractValidator<DogLeashEntity>
//    {
//        public DogLeashValidator() 
//        {
//            RuleFor(dogleash => dogleash.Name).NotNull();
//            RuleFor(dogleash => dogleash.Price).GreaterThanOrEqualTo(0);
//            RuleFor(dogleash => dogleash.Quantity).GreaterThanOrEqualTo(0);
//            RuleFor(dogleash => dogleash.Description).MaximumLength(15);

//        }
//    }
//}
