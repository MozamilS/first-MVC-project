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
            DogViewModel dog = new DogViewModel() { Name = "Hello", Age = 24 };
            return View(dog);
        }

        public string Hello()
        {
            return "You can make pages? Huh, didn't know that.";
        }

        
    }
}