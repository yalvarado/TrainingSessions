using System.ComponentModel.DataAnnotations;

namespace BasicMvc.ViewModel
{
    public class DoStuffViewModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get;  set; }
        
    }
}