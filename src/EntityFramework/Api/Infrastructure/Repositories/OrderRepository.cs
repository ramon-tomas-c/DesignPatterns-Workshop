using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly MyDbContext _ctx;

        public OrderRepository(MyDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Create(Order order)
        {
            _ctx.Orders.Add(order);
        }

        public void Delete(Order order)
        {
            _ctx.Orders.Remove(order);
        }

        public List<Order> GetAll()
        {
            return _ctx.Orders
                .Include(o => o.OrderItems)
                .ToList();
        }

        public Order GetById(int id)
        {
            return _ctx.Orders
                .Include(o => o.OrderItems)
                .Where(o => o.OrderId == id)
                .SingleOrDefault();
        }

        public void Update(Order order)
        {
            _ctx.Update(order);
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }       
    }
}
