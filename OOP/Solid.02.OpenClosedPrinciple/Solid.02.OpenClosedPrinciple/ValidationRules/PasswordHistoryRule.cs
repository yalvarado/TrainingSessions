using System.Linq;

namespace Solid_02_OpenClosedPrinciple.ValidationRules
{
    public class PasswordHistoryRule : IValidationRule<PasswordChangeModel>
    {
        public bool IsValid(PasswordChangeModel passwordChangeModel)
        {
            return passwordChangeModel.PasswordHistoryItems == null ||
                   
                   !passwordChangeModel.PasswordHistoryItems.Any
                       (x => x.PasswordText == passwordChangeModel.NewPassword);
        }
    }
}
