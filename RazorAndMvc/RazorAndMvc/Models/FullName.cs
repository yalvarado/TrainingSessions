using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorAndMvc.Models
{
    public class FullName
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public FullName(string fullName)
        {
            string[] fullnameArray = fullName.Split(' ');

            this.FirstName = fullnameArray[0];
            this.LastName = fullnameArray[1];
        }
    }
}
