using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace RazorAndMvc.Infrastructure
{
    // EXTENSION METHODS
    public static class HtmlHelpers
    {
        public static MvcHtmlString GetNumberOfDaysAlive(this HtmlHelper  html, DateTime dob)
        {                        
            return new MvcHtmlString(DateTime.Today.Subtract(dob).TotalDays.ToString());
        }
    }
}
