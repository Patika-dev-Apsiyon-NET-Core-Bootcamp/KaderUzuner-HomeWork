using HomeWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Domain.Interfaces
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
         Task<Restaurant> GetAllRestaurantWithCategories(int restaurantId);
    }
}
