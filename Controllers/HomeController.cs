using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CS_Time_Display_B.Models;

namespace CS_Time_Display_B.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


 

 
        [HttpGet]
        [Route("/")]
        public IActionResult Method()
        {
            // Do something with form input
            return View();
        }

        [HttpPost]
        [Route("Results")]
        public IActionResult Results(string Name, string Location, string Language, string Comment)
        {
            Console.WriteLine(Name);
            Console.WriteLine(Location);
            Console.WriteLine(Language);
            Console.WriteLine(Comment);

            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            // Do something with form input
            return View();
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
