using RestaurantAPI2.Data;
using RestaurantAPI2.Models;

namespace RestaurantAPI2.Repository
{
    public class OwnerRepository : BaseRepository<Owner>
    {
        public OwnerRepository(DataContext db) : base(db)
        {
        }

    }
}