using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    // demo/About
    public class DemoController : Controller
    {
        //demo is the Controller nAme
        //INdex is the action nAME
        // demo/Index
        //look for where u have
        //demo folder 
        //index.cshtml in the View
        public IActionResult Index()
        {
            return View();
        }

        // demo/About
        public IActionResult About()
        {
            return View();
        }
    }
}
