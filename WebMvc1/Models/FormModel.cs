using System.ComponentModel.DataAnnotations;

namespace WebMvc1.Models
{
    public class FormModel
    {
        [Display(Name = "Twoje imie: ")]
        public string Name { get; set; }
        [Display(Name = "Twoja data urodzenia: ")]
        public string Description { get; set; }
        
    }
}
