using System;
using System.ComponentModel.DataAnnotations;
namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,5, ErrorMessage="Choose a number between 1 & 5")]
        public int Tastiness { get; set; }
        [Required]
        [Range(0, 100000)]
        public int Calories { get; set; }
        [Required]
        public string Description { get; set; }
        public int ChefId { get; set; }
        public Chef Chef { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}