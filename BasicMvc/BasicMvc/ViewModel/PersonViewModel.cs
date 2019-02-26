using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicMvc.ViewModel
{
    public class PersonViewModel
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public PersonViewModel(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}