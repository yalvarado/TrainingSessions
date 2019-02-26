using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_02_OpenClosedPrinciple.ValidationRules
{
    public class PasswordMinLengthRule : IValidationRule<PasswordChangeModel>
    {
        private readonly int _minLength;

        public PasswordMinLengthRule(int minLength)
        {
            _minLength = minLength;
        }

        public bool IsValid(PasswordChangeModel passwordChangeModel)
        {
            return passwordChangeModel.NewPassword.Length >= _minLength;
        }
    }
}
