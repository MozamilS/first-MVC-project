using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace first_MVC_Project.Controllers
{
    public class helloWorldController : Controller
    {
        public string Index()
        {
            return "This is the default page";
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}