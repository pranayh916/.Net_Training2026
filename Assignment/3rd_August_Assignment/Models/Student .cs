using System.ComponentModel.DataAnnotations;

namespace _2nd_August_Practice.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Id is mandatory")]
        [Range(1, 9999, ErrorMessage = "Id must be between 1 and 9999")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        [StringLength(20, MinimumLength = 3,
            ErrorMessage = "Student name must be between 3 and 20 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Age is mandatory")]
        [Range(1, 120, ErrorMessage = "Age must be between 1 and 120")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Course is mandatory")]
        public string Course { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is mandatory")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; } = string.Empty;
    }
}