using RestaurantAPI2.Data;
using RestaurantAPI2.Models;

namespace RestaurantAPI2.Repository
{
    public class BranchRepository : BaseRepository<Branch>
    {


        public BranchRepository(DataContext db) : base(db)
        {
        }

    }
}
