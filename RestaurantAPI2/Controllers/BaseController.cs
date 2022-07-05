using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI2.CustomException;
using RestaurantAPI2.Handler;
using RestaurantAPI2.Repository;
using System.Collections.Generic;

namespace RestaurantAPI2.Controllers
{
    //[AuthenticationFilter]
    [Route("api/[controller]")]
   // [AuthenticationFilter]
    [ApiController]
    [Authorize]
    [CustomExceptionFilter]
    public class BaseController<T> : ControllerBase where T : class
    {
        protected IRepository<T> irepository;

        public BaseController(IRepository<T> irepository) { this.irepository = irepository; }


        // GET: api/<BaseController>
        [HttpGet]
        public ICollection<T> Get()
        {
            var data = irepository.GetAll();
            return data;
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        public T Get(int id)
        {
            var entity = irepository.Get(id);
            return entity;
        }

        // POST api/<BaseController>
        [HttpPost]
        public bool Post([FromBody] T entity)
        {
            var dPost = irepository.Add(entity);
            return dPost;
        }

        // PUT api/<BaseController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] T value)
        {
            var itemToUpdate = irepository.Update(value);
            return itemToUpdate;
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var itemTodelete = irepository.Delete(id);
            return itemTodelete;
        }
    }
}
