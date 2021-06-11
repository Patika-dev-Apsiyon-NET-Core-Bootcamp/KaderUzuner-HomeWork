using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.WebUI.Dtos
{
    public class CategoryWithFoodDto:CategoryDto
    {
        public List<FoodDto> Foods { get; set; }
    }
}
