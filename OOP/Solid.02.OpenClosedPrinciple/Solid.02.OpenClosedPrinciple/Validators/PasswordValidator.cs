using System;
using System.Collections.Generic;
using System.Text;
using Solid_02_OpenClosedPrinciple.ValidationRules;

namespace Solid_02_OpenClosedPrinciple.Validators
{
    public class PasswordValidator : BaseValidator<PasswordChangeModel>
    {
        public PasswordValidator(List<IValidationRule<PasswordChangeModel>> listOfRules,PasswordChangeModel model): base (listOfRules,model)
        {}
    }
}
