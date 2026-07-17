using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace FASS.Views.Account
{
    public class SignupModel : PageModel
    {
        [BindProperty]
        public SignupViewModel SignupViewModel { get; set; }

        public void OnGet()
        {
            // Initialize with default values if needed
            SignupViewModel = new SignupViewModel();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // TODO: Add your registration logic here
            // Example: Create user in database, send confirmation email, etc.

            // Redirect to login page after successful registration
            return RedirectToPage("/Account/Login");
        }
    }

    public class SignupViewModel
    {
        [Required(ErrorMessage = "Full name is required")]
        [Display(Name = "Full Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Full name must be between 2 and 100 characters")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "Username")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 20 characters")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Username can only contain letters, numbers, and underscores")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please select your role")]
        [Display(Name = "I want to")]
        public string Role { get; set; } = "Freelancer";

        [Display(Name = "Skills")]
        public string Skills { get; set; }

        [Required(ErrorMessage = "You must agree to the terms")]
        [Display(Name = "Agree to Terms")]
        public bool AgreeToTerms { get; set; }
    }
}