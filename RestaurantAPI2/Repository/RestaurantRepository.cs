using RestaurantAPI2.Data;
using RestaurantAPI2.Models;

namespace RestaurantAPI2.Repository
{
    public class RestaurantRepository : BaseRepository<Restaurant>
    {
        public RestaurantRepository(DataContext db) : base(db)
        {
        }

    }
}