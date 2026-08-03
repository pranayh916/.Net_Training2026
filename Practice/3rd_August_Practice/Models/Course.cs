using System.ComponentModel.DataAnnotations;

namespace _2nd_August_Practice.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string CourseName { get; set; } = string.Empty;

        [Required]
        public string Department { get; set; } = string.Empty;

        [Required]
        public int Fees { get; set; }
    }
}