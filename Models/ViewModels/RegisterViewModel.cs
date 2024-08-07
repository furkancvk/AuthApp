using System.ComponentModel.DataAnnotations;

namespace AuthApp.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username is required")]
        public string? Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Surname is required")]

        public string? Surename { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gender is required")]
        public string? Gender { get; set; }
    }
}