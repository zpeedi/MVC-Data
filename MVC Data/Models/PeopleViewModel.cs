using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_Data.Models
{
    public class PeopleViewModel
    {
        public List<Person> People { get; set; }
        [Required(ErrorMessage ="Du måste ange en söksträng")]
        public string SearchString { get; set; }
      


        public List<Person> Search()
        {
            List<Person> searchResult = new List<Person>(); 
            foreach(Person p in People)
            {
                if (p.City.Equals(SearchString))
                {
                    searchResult.Add(p);
                }
            }
            return searchResult;
        }
    }
}
