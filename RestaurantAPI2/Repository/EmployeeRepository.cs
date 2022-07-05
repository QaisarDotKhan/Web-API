using RestaurantAPI2.Data;
using RestaurantAPI2.Models;

namespace RestaurantAPI2.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(DataContext db) : base(db)
        {
        }

    }
}
