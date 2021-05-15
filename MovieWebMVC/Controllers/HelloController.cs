using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebMVC.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["numTimes"] = numTimes;

            return View();
        }

        public IActionResult Today()
        {
            ViewData["Message"] = $"De datum van vandaag is {DateTime.Now.ToShortDateString()} en het uur {DateTime.Now.ToShortTimeString()}";
            
            return View();
        }
    }
}
