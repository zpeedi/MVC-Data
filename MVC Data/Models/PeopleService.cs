using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Data.Models
{
    public class PeopleService : IPeopleService
    {
        private IPeopleRepo peopleRepo = new InMemoryPeopleRepo();
        public Person Add(CreatePersonViewModel person)
        {
            return peopleRepo.Create(person.Name, person.PhoneNumber, person.City);
        }
        public PeopleViewModel All()
        {
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            peopleViewModel.People = new List<Person>(); 
            foreach(Person p in peopleRepo.Read())
            {
                peopleViewModel.People.Add(p);
            }          
            return peopleViewModel;
        }
        public PeopleViewModel FindBy(PeopleViewModel search)
        {
            PeopleViewModel returnModel = new PeopleViewModel();
            returnModel.People = new List<Person>();
            foreach(Person p in search.People)
            {
                System.Diagnostics.Debug.WriteLine(p.City + " : " + search.SearchString);
                if (p.City.Contains(search.SearchString))
                {
                   
                    returnModel.People.Add(p);
                }
            }
            return returnModel;
        }
        public Person FindBy(int id)
        {
            return null;
        }
        public Person Edit(int d, Person person)
        {
            return null;
        }
        public bool Remove(int id)
        {
            return false;
        }
    }
}
