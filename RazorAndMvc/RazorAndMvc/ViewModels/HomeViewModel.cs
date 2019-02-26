using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorAndMvc.Models;

namespace RazorAndMvc.ViewModels
{
    public class HomeViewModel
    {
        public string PageTitle => "Home Page";

        public FullName FullName
        {
            get { return new FullName("Perico Palotes"); }
        }    

        public DateTime DateOfBirth => new DateTime(1984,11,11);


    }
}
