using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Userin
    {
        [Required]
        [Key]
        [RegularExpression("^[a-zA-Z0-9]{5,10}$", ErrorMessage = "UserId must be between 5 and 10 alphanumeric characters.")]
        public string UserId { get; set; } = "";

        [Required]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "UserName can only contain letters and spaces.")]
        public string UserName { get; set; } = "";

        [Required]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Mobile must be a 10-digit number.")]
        public string Mobile { get; set; } = "";

        [Required]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "UserPassword can only contain letters and numbers.")]
        public string UserPassword { get; set; } = "";
    }
}
