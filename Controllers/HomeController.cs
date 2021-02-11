using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index()
        {
            // Create and populate the list using the array returned form GetRestaurants
            List<Restaurant> restaurants = new List<Restaurant>();
            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                restaurants.Add(r);
            }
            return View(restaurants); // pass the list to the view
        }

        public IActionResult Suggestion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Suggestion(Suggestion s)
        {
            SuggestionStorage.AddSuggestion(s); // Add a suggestion to the storage upon submission
            return View("Success"); // Return success
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult Suggestions()
        {
            return View(SuggestionStorage.Suggestions); // pass stored suggestions to view
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
