using System.ComponentModel.DataAnnotations;

namespace _29_july_Practice_2.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; } = string.Empty;

        [Required]
        public string Model { get; set; } = string.Empty;

        public string Color { get; set; } = string.Empty;

        public decimal Price { get; set; }
    }
}