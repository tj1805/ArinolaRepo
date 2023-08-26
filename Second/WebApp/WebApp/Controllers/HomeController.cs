using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{

    //A controller is class 
    //it inherit from Controller class 
    public class HomeController : Controller
    {
        //the Url u specifed map to a method on the Controller , den the controller maps that same Url to a VIEW IN TH vIEWS
        //folder
        //a filed
        private readonly ILogger<HomeController> _logger;
        //a constructor
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //A method name Index 
        //wuth reutrn type is  IACTIONrESULT and IACTIONRESULT Is an Interface
        //t
        public IActionResult Index()
        {
            return View();
        }

        //Home is the Controller
        //Privacy is the Mehtod
        //  https://localhost:44300/Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }
        //Firegt about these One
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


//Ir  controller is like wat relates to the Outside, 
//Model basically holds the appplication entity and Performs DataAccess
//ur views is basically the Ui