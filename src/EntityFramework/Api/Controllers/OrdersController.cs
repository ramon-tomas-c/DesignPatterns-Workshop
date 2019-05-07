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
        private readonly IRepository<Order> _repository;
        public OrdersController(IRepository<Order> repository)
        {
            _repository = repository;
        }

        // GET api/orders
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        // GET api/orders/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var order = _repository.GetById(id);
            if (order == null)
            {
                return BadRequest();
            }

            return Ok(order);
        }

        // POST api/orders
        [HttpPost]
        public IActionResult Post()
        {
            var order = new Order()
            {
                OrderDate = DateTime.Now
            };

            _repository.Create(order);
            _repository.Save();

            return Ok();
        }

        // PUT api/orders/5
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            var order = _repository.GetById(id);
            if(order == null)
            {
                return BadRequest();
            }

            var item = new OrderItem() { Desc = "new Item" };

            order.OrderItems.Add(item);

            _repository.Update(order);
            _repository.Save();

            return Ok();
        }

        // DELETE api/orders/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var order = _repository.GetById(id);
            if (order == null)
            {
                return BadRequest();
            }

            _repository.Delete(order);
            _repository.Save();

            return Ok();
        }
    }
}
