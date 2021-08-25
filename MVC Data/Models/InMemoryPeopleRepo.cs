using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Data.Models
{
    public class InMemoryPeopleRepo : IPeopleRepo
    {
        private static List<Person> persons = new List<Person>();
        private static int idCounter;

        public Person Create(string name, string phoneNumber, string city)
        {
            Person p = new Person(name, phoneNumber, city, idCounter++);
            persons.Add(p);
            return p;
        }
        public List<Person> Read()
        {
            return persons;
        }
        public Person Read(int id)
        {
            foreach(Person p in persons)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            return null;
        }
        public Person Update(Person person)
        {
            return new Person("d", "f", "d",idCounter++);
        }
        public bool Delete(Person person)
        {
            return false;
        }
    }
}
