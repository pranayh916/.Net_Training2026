using System.ComponentModel.DataAnnotations;

namespace _6th_August_Practice.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int Pid { get; set; }   // Primary Key

        [Required(ErrorMessage = "Product Name is required")]
        public string Pname { get; set; } = string.Empty;

        [Required]
        [Range(1, 100, ErrorMessage = "Product quantity must be between 1 and 100.")]
        public int Pquantity { get; set; }

        [Required]
        [Range(15, 100000, ErrorMessage = "Product price must be between 15 and 100000.")]
        public double Pprice { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 2,
            ErrorMessage = "Availability must be 'Yes' or 'No'.")]
        public string Pavailability { get; set; } = string.Empty;
    }
}