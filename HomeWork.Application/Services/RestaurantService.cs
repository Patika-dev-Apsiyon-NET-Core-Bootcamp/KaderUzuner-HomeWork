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
    public class RestaurantService : Service<Restaurant>, IRestaurantService
    {
       
        public RestaurantService(IRepository<Restaurant>repository):base(repository)
        {

        }
        public async Task<Restaurant> GetAllRestaurantWithCategories(int restaurantId)
        {
            return await Restaurant.GetAllRestaurantWithCategories(restaurantId);
        }
    }
}
