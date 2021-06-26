using HomeWork.Application.Services;
using HomeWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Application.Interface
{
    public interface IRestaurantService: IService<Restaurant>
    {
        Task<Restaurant> GetAllRestaurantWithCategories(int restaurantId);
    }
    
    
}
