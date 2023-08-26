using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class TestController : Controller
    {
        //Navigation
        //Passing Data
       //vIEWbAG vIEWbAG
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Demo()
        {
            return View();
        }
        public IActionResult Data()
        {
            ViewBag.Name = "Adebanjo Oluwasola";
            ViewBag.Age = 234;
            ViewBag.Boyfriend = 'A';
            return View();
        }

    }
}
