using System.ComponentModel.DataAnnotations;

namespace _6th_and_5th_August_Assignment.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string CustomerName { get; set; } = string.Empty;

        [Required]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        public int Quantity { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
    }
}