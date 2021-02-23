using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(5);
            RuleFor(c => c.DailyPrice).GreaterThan(100);
            RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(2018).When(c => c.BrandId == 3);
            RuleFor(c => c.ModelYear).GreaterThan(2000);
            
        }
    }
}
