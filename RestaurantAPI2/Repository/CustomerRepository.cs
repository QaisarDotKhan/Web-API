using RestaurantAPI2.Data;
using RestaurantAPI2.Models;

namespace RestaurantAPI2.Repository
{
    public class CustomerRepository : BaseRepository<Customer>
    {
            public CustomerRepository(DataContext db) : base(db)
            {
            }

    }
}
