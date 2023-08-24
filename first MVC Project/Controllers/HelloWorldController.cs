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

        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()

        {
            return View(dogs);
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
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
        
    }
}