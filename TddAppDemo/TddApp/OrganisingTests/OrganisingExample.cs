using System;
using System.Collections.Generic;
using System.Text;

namespace TddApp.OrganisingTests
{
    public class OrganisingExample
    {
        public bool IsEven(int number)
        {
            return (number % 2)==0;
        }

        public bool IsOdd(int number)
        {
            return !this.IsEven(number);
        }
    }
}
