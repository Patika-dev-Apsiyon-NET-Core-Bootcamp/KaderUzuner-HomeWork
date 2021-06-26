using HomeWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Application.Interface
{
    public interface ICategoryService:IService<Category>
    {
        Task<List<Category>> GetAllWithFood(int categoryId);
        Task<Category> GetMenuByRestaurant(int restaurantId);
    }
}
