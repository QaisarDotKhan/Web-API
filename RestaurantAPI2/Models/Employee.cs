using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI2.Models
{
    public class Employee
    {
        [Key]
        public int empID { get; set; }
        [Required]
        [MaxLength(100)]
        public string empName { get; set; }
        [Required]
        public string empRoll { get; set; }
    }
}
