using HomeWork.Domain.Models;
using HomeWork.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Infrastructure.Data.Repository
{
    public class Repository<TEntity> where TEntity : Entity, new()
    {
        protected readonly HomeWorkDbContext _context = null;
        private DbSet<TEntity> _entities = null;

        public Repository(HomeWorkDbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }


        public async Task<int> Add(TEntity entity)
        {
            _entities.Add(entity);
            return await _context.SaveChangesAsync();
        }

        public int Update(TEntity entity)
        {
            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            TEntity entity = _entities.FirstOrDefault(x => x.Id == id);
            if (entity == default) return -1;
            _entities.Remove(entity);
            return _context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return _entities.FirstOrDefault(x => x.Id == id);

        }

        public List<TEntity> GetAll()
        {
            return _entities.ToList();
        }

    }
}
