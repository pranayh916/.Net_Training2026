using System.ComponentModel.DataAnnotations;

namespace _4_august_practice.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Age { get; set; }

        [Required]
        public string Course { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = string.Empty;
    }
}