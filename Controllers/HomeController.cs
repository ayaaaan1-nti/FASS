using FASS.Models;
using Freelancer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FASS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        // GET: /Home/CreateAccount
        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View(); // or return View(new RegisterViewModel());
        }

        // POST: /Home/CreateAccount
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAccount(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO: Create the user / save to database
            // If you are using ASP.NET Core Identity, this is where you'd call:
            // - _userManager.CreateAsync(...)
            // - _signInManager.SignInAsync(...)
            // - role assignment

            // Example redirect (change to your page)
            return RedirectToAction("Login");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}