using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MVC_Data.Models
{
    public class Person {

        public int Id { get; }
        [Required(ErrorMessage ="Namn krävs")]
        public string Name { get; set; }
        [Required(ErrorMessage = "telefonnummer krävs")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Stad krävs")]
        public string City { get; set; }

        public Person(string name, string phoneNumber, string city, int id)
        {           
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.City = city;
            this.Id = id;
        }
    }
}
