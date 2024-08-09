using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class TravelCostValidator : AbstractValidator<TravelCost>
    {
        public TravelCostValidator()
        {
            RuleFor(x=>x.Title).NotEmpty();
        }
    }
}
