using HomeWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity, new()
    {
        Task Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task <TEntity> GetById(int  id);
        Task <List<TEntity>> GetAll();
    }
}
