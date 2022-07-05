using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI2.Models
{
    public class Restaurant
    {
        [Key]
        public int restaurantID { get; set; }
        [Required]
        [MaxLength(100)]
        public string restaurantName { get; set; }
        [Required]
        [MaxLength (100)]
        public string restaurantType { get; set; }
        [Required]
        [MaxLength(100)]
        public string restaurationLocation { get; set; }
    }
}
