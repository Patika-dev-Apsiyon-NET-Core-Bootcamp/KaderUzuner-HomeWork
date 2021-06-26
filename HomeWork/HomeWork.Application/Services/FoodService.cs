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
    public class FoodService: Service<Food>, IFoodService
    {
        public FoodService(IRepository<Food> repository) : base( repository)
        {

        }
    }
}
