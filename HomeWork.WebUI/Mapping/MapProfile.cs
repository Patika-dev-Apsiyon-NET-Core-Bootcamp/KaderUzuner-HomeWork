using AutoMapper;
using HomeWork.Domain.Models;
using HomeWork.WebUI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.WebUI.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Food, FoodDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Restaurant, RestaurantDto>().ReverseMap();
            CreateMap<Category, CategoryWithFoodDto>().ReverseMap();
            CreateMap<Category, CategoryWithRestaurantDto>().ReverseMap();
        }
    }
}
