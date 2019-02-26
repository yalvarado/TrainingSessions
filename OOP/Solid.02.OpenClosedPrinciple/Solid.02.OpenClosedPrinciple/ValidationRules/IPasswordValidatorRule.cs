using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_02_OpenClosedPrinciple.ValidationRules
{
    public interface IValidationRule<TModel>
    {
        bool IsValid(TModel model);
    }
}
