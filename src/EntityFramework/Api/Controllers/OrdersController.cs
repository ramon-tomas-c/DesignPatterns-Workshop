using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Infrastructure.Repositories;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        public OrdersController()
        {
            
        }

        // GET api/orders
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        // GET api/orders/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            
            return Ok();
        }

        // POST api/orders
        [HttpPost]
        public IActionResult Post()
        {
            var order = new Order()
            {
                OrderDate = DateTime.Now
            };

           
            return Ok();
        }

        // PUT api/orders/5
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
           

            
            return Ok();
        }

        // DELETE api/orders/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
            return Ok();
        }
    }
}
