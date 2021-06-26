using HomeWork.Application.Interface;
using HomeWork.Domain.Interfaces;
using HomeWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Application.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : Entity, new()
    {
        public readonly IRepository<TEntity> _repository;
        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public Task Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
