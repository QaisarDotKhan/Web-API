using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI2.Models
{
    public class Order
    {
        [Key]
        public int orderID { get; set; }
        [Required]
        public int orderPrice { get; set; }
        [Required]
        public string orderDate { get; set; }
        [Required]
        public string orderTime { get; set; }

        [ForeignKey("dishID")]
        public int dishID { get; set; }
        public List<Dish> dishes { get; set; }

    }
}
