using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_02_OpenClosedPrinciple.ValidationRules
{
    public class PasswordUsernameRule : IValidationRule<PasswordChangeModel>
    {
        public bool IsValid(PasswordChangeModel passwordChangeModel)
        {
            return passwordChangeModel.NewPassword != passwordChangeModel.Username;
        }
    }
}
