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
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(HomeWorkDbContext context) : base(context)
        {
        }

        public async Task<List<Restaurant>> GetAllRestaurantWithMenu(int categoryId)
        {
            return await _context.Restaurant.Include(m => m.Categories).ToListAsync();
        }
    }
}
