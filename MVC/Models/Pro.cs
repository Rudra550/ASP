using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Pro
    {
        [Required]
        [Key]
        [RegularExpression("^[a-zA-Z0-9]{5,10}$", ErrorMessage = "EmployeeId must be between 5 and 10 alphanumeric characters.")]
        public string EmployeeId { get; set; } = "";

        [Required]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Name can only contain letters, numbers, and spaces.")]
        public string EmployeeName { get; set; } = "";

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "AmountPaid must be a positive number.")]
        public int AmountPaid { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9 ]+$", ErrorMessage = "EventName can only contain letters, numbers, and spaces.")]
        public string EventName { get; set; } = "";
    }
}
