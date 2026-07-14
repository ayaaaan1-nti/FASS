using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Freelancer.Models;

namespace Freelancer.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Re-render the same page (e.g. the home page's #login section)
                // with validation errors if this is a partial/section on Index.
                return View(model);
            }

            // TODO: replace with real authentication (e.g. ASP.NET Core Identity)
            // var result = await _signInManager.PasswordSignInAsync(
            //     model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
            // if (result.Succeeded) return RedirectToAction("Index", "Home");

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(model);
        }
    }
}