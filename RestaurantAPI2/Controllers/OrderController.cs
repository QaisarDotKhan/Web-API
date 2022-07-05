﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI2.Handler;
using RestaurantAPI2.Models;
using RestaurantAPI2.Repository;

namespace RestaurantAPI2.Controllers
{
    [Route("api/[controller]")]
  //  [AuthenticationFilter]
    [ApiController]
    public class OrderController : BaseController<Order>
    {
       
            public OrderController(IRepository<Order> irepository) : base(irepository)
            {
            }

    }
}
