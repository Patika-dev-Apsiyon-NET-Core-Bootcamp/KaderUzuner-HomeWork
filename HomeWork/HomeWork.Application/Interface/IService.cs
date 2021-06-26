using HomeWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Application.Interface
{
    public interface IService<TEntity> where TEntity : Entity, new()
    {
        Task Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        Task<TEntity> GetById(int id);
        Task<List<TEntity>> GetAll();
    }
}
