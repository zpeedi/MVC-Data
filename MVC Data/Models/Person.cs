using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Data.Models
{
    public class Person {

        public int Id { get; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
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
