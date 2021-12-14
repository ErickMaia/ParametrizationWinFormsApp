using FluentValidation.Results;
using ParametrizationApp.Core.Models;
using ParametrizationApp.Core.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrizationApp.Core.Services
{
    public class ParametrizationService
    {

        public Parametrization ReadParametrization()
        {
            //call repository
            return new Parametrization();
        }

        public List<string> InsertUpdateParametrization(Parametrization parametrization)
        {
            List<string> errors = Validate(parametrization);
            if (!errors.Any())
            {
                //call repository for data persistence
            }
                
            return errors; 
        }

        public List<string> Validate(Parametrization parametrization)
        {
            List<string> errors = new List<string>();

            ParametrizationValidator validationRules = new ParametrizationValidator();
            ValidationResult validationResult = validationRules.Validate(parametrization);

            if(!validationResult.IsValid){
                validationResult.Errors.ForEach(x => errors.Add(x.ErrorMessage));
            }

            return errors; 
        }
        
    }
}
