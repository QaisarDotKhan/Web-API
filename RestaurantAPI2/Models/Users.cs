using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI2.Models
{
    public class Users
    {
        [Key]
        public string Userid { get; set; } = null!;
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }
        public int? JobId { get; set; }
    }
}
