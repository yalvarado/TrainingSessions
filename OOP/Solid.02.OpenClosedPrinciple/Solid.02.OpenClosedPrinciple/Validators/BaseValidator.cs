using System;
using System.Collections.Generic;
using System.Text;
using Solid_02_OpenClosedPrinciple.ValidationRules;
using Solid_02_OpenClosedPrinciple.Validators;

namespace Solid_02_OpenClosedPrinciple.Validators
{
    public abstract class BaseValidator<TModel> : IValidator
    {
        private readonly List<IValidationRule<TModel>> _validationRules;
        private readonly TModel _model;

        protected BaseValidator(List<IValidationRule<TModel>> validationRules, TModel model)
        {
            this._validationRules = validationRules;
            this._model = model;
        }

        public bool IsValid()
        {
            foreach (var validationRule in _validationRules)
            {
                if (!validationRule.IsValid(this._model))                
                    return false;                
            }

            return true;
        }
    }
}
