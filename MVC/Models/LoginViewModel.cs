using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class LoginViewModel
    {
        [Required]
        [RegularExpression("^[a-zA-Z0-9]{5,10}$", ErrorMessage = "UserId must be between 5 and 10 alphanumeric characters.")]
        public string UserId { get; set; } = "";

        [Required]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Password can only contain letters and numbers.")]
        public string Password { get; set; } = "";
    }
}
