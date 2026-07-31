using System.ComponentModel.DataAnnotations;

namespace _24_july_Practice.Models
{
    public class Student
    {
        [Required(ErrorMessage="Username is Required")]
         public  string username { get; set;}
        [Required(ErrorMessage = "password is Required")]
        public string password { get; set; }
    }
}
