using Microsoft.AspNetCore.Mvc;
using MVC_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Data.Controllers
{
    public class HomeController : Controller
    {

        IPeopleService service;

        public HomeController()
        {
            service = new PeopleService();
        }
        [HttpGet]
        public IActionResult People()
        {           
            return View("People", service.All());
        }
        [HttpPost]
        public IActionResult People(PeopleViewModel peopleViewModel)
        {
            PeopleViewModel search = service.All();
            search.SearchString = peopleViewModel.SearchString;
        
            return View("People", service.FindBy(search));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(CreatePersonViewModel newPerson)
        {
            service.Add(newPerson);
            return RedirectToAction("Create");
        }
    }
}
