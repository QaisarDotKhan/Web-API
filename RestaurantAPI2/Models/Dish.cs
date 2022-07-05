using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI2.Models
{
    public class Dish
    {
        [Key]
        public int dishID { get; set; }
        [Required]
        [MaxLength(100)]
        public string dishName { get; set; }
        [Required]
        [MaxLength(200)]
        public string dishIngredient { get; set; }
        [Required]
        public string dishPrice { get; set; }

        [ForeignKey("orderID")]
        public int orderID { get; set; }
        public List<Order> orders { get; set; }

        [ForeignKey("branchID")]
        public int branchID { get; set; }
        public List<Branch> branches { get; set; }
    }
}
