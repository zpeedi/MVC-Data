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
            if (ModelState.IsValid)
            {
                PeopleViewModel search = service.All();
                search.SearchString = peopleViewModel.SearchString;
        
                return View("People", service.FindBy(search));
            }
            else
            {
                return View("People", service.All());
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(CreatePersonViewModel newPerson)
        {
            if (ModelState.IsValid)
            {
                service.Add(newPerson);
                return RedirectToAction("Create");
            }
            else
            {
                return View();
            }
        }
    }
}
