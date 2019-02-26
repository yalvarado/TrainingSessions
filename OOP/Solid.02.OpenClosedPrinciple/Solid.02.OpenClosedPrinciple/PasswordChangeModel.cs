using System;
using System.Collections.Generic;
using System.Text;

namespace Solid_02_OpenClosedPrinciple
{
    public class PasswordChangeModel
    {
        public string NewPassword { get; set; }
        public List<PasswordHistoryItem> PasswordHistoryItems { get; set; }
        public string Username { get; set; }
    }
}
