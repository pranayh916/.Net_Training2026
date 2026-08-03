using System.ComponentModel.DataAnnotations;

namespace _2nd_August_Practice.Models
{
    public class Batch
    {
        public int Id { get; set; }

        [Required]
        public string BatchName { get; set; } = string.Empty;

        [Required]
        public string TrainerName { get; set; } = string.Empty;

        [Required]
        public int Duration { get; set; }
    }
}