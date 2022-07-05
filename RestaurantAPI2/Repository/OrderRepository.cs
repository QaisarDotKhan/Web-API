using RestaurantAPI2.Data;
using RestaurantAPI2.Models;

namespace RestaurantAPI2.Repository
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(DataContext db) : base(db)
        {
        }

    }
}