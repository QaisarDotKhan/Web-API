using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI2.Models
{
    public class Customer
    {
        [Key]
        public int customerID { get; set; }
        [Required]
        [MaxLength(100)]
        public string customerName { get; set; }
        [Required]
        [MaxLength(11)]
        public string customerPhone { get; set; }
        [Required]
        public string customerEmail { get; set; }

        [ForeignKey("orderID")]
        public int orderID { get; set; }
        public List<Order> orders { get; set; }
    }
}
