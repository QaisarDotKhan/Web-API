using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI2.Models
{
    public class Owner
    {
        [Key]
        public int ownerID { get; set; }
        [Required]
        [MaxLength(100)]
        public string ownerName { get; set; }
        [Required]
        [MaxLength(11)]
        public string ownerPhone { get; set; }

    }
}
