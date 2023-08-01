using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using first_MVC_Project.Models;

namespace first_MVC_Project.Controllers
{
    public class helloWorldController : Controller
    {
        public IActionResult Index()


        {
            DogViewModel dog = new DogViewModel() { Name = "Sasha Banks", Age = 24 };
            return View(dog);
        }

        public IActionResult Hello()
        {
            return View();
        }

        public IActionResult Create()
        {
            var dogVM = new DogViewModel();
            return View(dogVM);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            return View();
        }
        
    }
}