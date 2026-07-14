using System.ComponentModel.DataAnnotations;

namespace Freelancer.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "An email is required.")]
        [EmailAddress(ErrorMessage = "Email is not valid.")]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}