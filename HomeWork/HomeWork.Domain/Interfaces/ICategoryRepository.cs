using HomeWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Domain.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<List<Category>> GetAllWithFood(int categoryId);
        Task<Category> GetCategoryByRestaurant(int restaurantId);
    }
}
