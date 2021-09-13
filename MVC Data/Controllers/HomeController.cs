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
            if (String.IsNullOrEmpty(search.SearchString))
            {
                return View("People", service.All());
            }
            else
            {
                return View("People", service.FindBy(search));

            }/*
            if (ModelState.IsValid)
            {
                PeopleViewModel search = service.All();
                search.SearchString = peopleViewModel.SearchString;
        
                return View("People", service.FindBy(search));
            }
            else
            {
                return View("People", service.All());
            }*/
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("People", service.All());
        }
        [HttpPost]
        public IActionResult Create(PeopleViewModel peopleViewModel)
        {
            //service.Add(peopleViewModel.CreatePersonViewModel);
            //return RedirectToAction("People");
            
            if (ModelState.IsValid)
            {
                service.Add(peopleViewModel.CreatePersonViewModel);
                return RedirectToAction("People");
            }
            else
            {
                return RedirectToAction("People");
            }
        }
    }
}
