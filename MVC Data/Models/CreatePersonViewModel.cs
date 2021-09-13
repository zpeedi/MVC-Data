using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_Data.Models
{
    public class CreatePersonViewModel
    {
        [Display(Name="Namn: ")]
        [Required(ErrorMessage ="Skriv in ett namn")]
        public string Name { get; set; }
        [Display(Name="Telefonnummer: ")]
        [Required(ErrorMessage = "Skriv in ett telefonnummer")]
        public string PhoneNumber { get; set; }
        [Display(Name="Bostadsort: ")]
        [Required(ErrorMessage = "Skriv in en stad")]
        public string City { get; set; }
    }
}
