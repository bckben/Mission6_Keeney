using Microsoft.AspNetCore.Mvc;
using Mission6_Keeney.Models;

namespace Mission6_Keeney.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext temp)
        {
            _context = temp;
        }

        // Index page for home
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        // Show the Add Movie form
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        // Handle the Add Movie form submission
        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                // Add the movie to the database
                _context.Movies.Add(movie);
                _context.SaveChanges();  // Ensure the async method is awaited

                // Redirect to the Confirmation view after adding the movie
                return View("Confirmation", movie);
            }

            // If the form submission is not valid, return to the AddMovie form with validation errors
            return View("AddMovie", movie);
        }

    }
}