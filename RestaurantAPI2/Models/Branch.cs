using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI2.Models
{
    public class Branch
    {
        [Key]
        public int branchID { get; set; }
        [Required]
        [MaxLength(100)]
        public string branchCityName { get; set; }
        [Required]
        [MaxLength(11)]
        public string branchTelephone { get; set; }
        [Required]
        public int branchTotalEmployees { get; set; }

        [ForeignKey("ownerID")]
        public int ownerID { get; set; }
        public Owner owner { get; set; }
        public List<Dish> dishes { get; set; }
        public List<Employee> employees { get; set; }
    }
}
