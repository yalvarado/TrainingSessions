using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicMvc.ViewModel
{
    public class ExampleViewModel
    {
        public string XtraProperty { get; private set; }
        public PersonViewModel Person { get; private set; }

        public ExampleViewModel(string xtraProperty, PersonViewModel person)
        {
            this.XtraProperty = xtraProperty;
            this.Person = person;
        }
    }
}