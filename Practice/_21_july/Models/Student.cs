using System.ComponentModel.DataAnnotations;

namespace _21_july.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Mobile is required")]
        public string? Mobile { get; set; }
    }
}