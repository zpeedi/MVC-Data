using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_Data.Models
{
    public class CreatePersonViewModel
    {
        [Required(ErrorMessage ="Skriv in ett namn")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Skriv in ett telefonnummer")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Skriv in en stad")]
        public string City { get; set; }
    }
}
