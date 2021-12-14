using FluentValidation;
using ParametrizationApp.WinForms.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrizationApp.WinForms.Validators
{
    public class ParametrizationValidator : AbstractValidator<Parametrization>
    {
        public ParametrizationValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("The username must not be null. ");
            RuleFor(x => x.MinutesBeforeIntegration).GreaterThanOrEqualTo(15).WithMessage("There must be at least 15 minutes before integration. Please, set a higher value. "); 
        }
            
    }
}
