using Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Infrastructure
{
    public class MyDbContext : DbContext
    {
       
        
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{            
        //     optionsBuilder.UseSqlServer(
        //         @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
        //}
        
    }
}
