using Microsoft.EntityFrameworkCore;
using RestaurantAPI2.Models;

namespace RestaurantAPI2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Branch> branches { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Dish> dishes { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Owner> owner { get; set; }
        public DbSet<Restaurant> restaurants { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
