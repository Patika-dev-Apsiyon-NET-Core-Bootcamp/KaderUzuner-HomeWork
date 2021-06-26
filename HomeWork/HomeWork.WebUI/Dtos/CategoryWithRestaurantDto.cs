using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.WebUI.Dtos
{
    public class CategoryWithRestaurantDto:CategoryDto
    {
        public List<RestaurantDto> Restaurants { get; set; }
    }
}
