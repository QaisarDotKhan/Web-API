using RestaurantAPI2.Data;
using RestaurantAPI2.Models;

namespace RestaurantAPI2.Repository
{
    public class DishRepository : BaseRepository<Dish>
    {
        public DishRepository(DataContext db) : base(db)
        {
        }

    }
}
