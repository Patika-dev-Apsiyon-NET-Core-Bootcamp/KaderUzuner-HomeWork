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
    public class CategoryService : Service<Category>, ICategoryService
    {
       
        public CategoryService(IRepository<Category> repository):base(repository)
        {
                
        }
        public async Task<List<Category>> GetAllWithFood(int categoryId)
        {
            return await Categories.GetAllWithFood(categoryId);
        }


        public async Task<Category> GetMenuByRestaurant(int restaurantId)
        {
            return await Categories.GetMenuByRestaurant(restaurantId);
        }
    }
    
}

