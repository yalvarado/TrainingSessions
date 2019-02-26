using System;
using System.Collections.Generic;
using System.Text;
using Solid_02_OpenClosedPrinciple.ValidationRules;
using Solid_02_OpenClosedPrinciple.Validators;

namespace Solid_02_OpenClosedPrinciple
{
    public class Consumer1
    {
        private const int MAXIMUM_PASSWORD_LENGTH = 20;


        public void SomeMethod(PasswordChangeModel passwordChangeModel)
        {
            
            var passwordValidator = new PasswordValidator(this.GetPasswordValidationRules(), passwordChangeModel);

            if (passwordValidator.IsValid())
                Console.WriteLine("Success");
            else
                Console.WriteLine("Failure");

            
        }

        private List<IValidationRule<PasswordChangeModel>> GetPasswordValidationRules()
        {
            return new List<IValidationRule<PasswordChangeModel>>()
            {
                new PasswordMinLengthRule(MAXIMUM_PASSWORD_LENGTH),
                new PasswordUsernameRule(),
                new PasswordHistoryRule()
            };
        }

    }
}
