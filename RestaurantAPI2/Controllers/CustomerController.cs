using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI2.Models;
using RestaurantAPI2.Repository;

namespace RestaurantAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseController<Customer>
    {
        

            public CustomerController(IRepository<Customer> irepository) : base(irepository)
            {
            }

    }
}
