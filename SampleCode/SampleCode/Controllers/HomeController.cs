using Microsoft.AspNetCore.Mvc;
using SampleCode.Models;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace SampleCode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult User()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        
        [HttpPost]
        public IActionResult SaveUser(User user)
        {
            if (ModelState.IsValid)
            {
                var json = JsonConvert.SerializeObject(user, Formatting.Indented);

                string filePath = _configuration.GetSection("FilePath").Value;
                System.IO.File.WriteAllText(filePath, json);

                ViewBag.Message = "Saved successfully";
                return View("User");
            }
            return View("User");
        }
    }
}