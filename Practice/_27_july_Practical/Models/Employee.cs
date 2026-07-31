using System.ComponentModel.DataAnnotations;

namespace _27_july_Practical.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Id is mandatory")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="Name must be at least 3 character ")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name is mandatory")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Department is mandatory")]
        public string Department { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mobile number is mandatory")]
        [Phone(ErrorMessage = "Enter a valid mobile number")]
        public string Mobile { get; set; } = string.Empty;
    }
}