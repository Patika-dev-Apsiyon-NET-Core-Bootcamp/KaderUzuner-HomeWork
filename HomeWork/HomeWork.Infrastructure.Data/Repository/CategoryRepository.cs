using HomeWork.Domain.Interfaces;
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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(HomeWorkDbContext context) : base(context)
        {
        }

        public async Task<List<Category>> GetAllcategoryWithFood(int foodId)
        {
            return await _context.Categories.Include(f => f.Foods).ToListAsync();
        }

        public async Task<List<Category>> GetAllWithFood(int categoryId)
        {
            return await _context.Categories.Where(x => x.Id == categoryId).ToListAsync();
        }

        public async Task<Category> GetCategoryByRestaurant(int restaurantId)
        {
            return await _context.Categories.Include(x => x.Foods).SingleOrDefaultAsync(x => x.RestaurantId == restaurantId);
        }


        Task IRepository<Category>.Add(Category entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Category>.Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        Task<List<Category>> IRepository<Category>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<Category> IRepository<Category>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Category>.Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
