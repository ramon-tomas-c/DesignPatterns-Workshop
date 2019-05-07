using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Infrastructure.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Create(TEntity order);
        void Update(TEntity order);
        void Delete(TEntity order);
        void Save();
    }
}
