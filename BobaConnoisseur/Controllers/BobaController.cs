using BobaConnoisseur.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BobaConnoisseur.Controllers
{
    //created public class for BobaController
    public class BobaController : Controller
    {
        private readonly ILogger<BobaController> _logger;
        //defualt code from MVC app
        public BobaController(ILogger<BobaController> logger)
        {
            _logger = logger;
        }
        //This method returns a View result for the Index page.Renders Index page when requested
        public IActionResult Index()
        {
            return View();
        }
        //This method returns a View result for the Calculator page.Renders Calculator page when requested
        public IActionResult Calculator()
        {
            return View();
        }
        //default code form MVC app 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
