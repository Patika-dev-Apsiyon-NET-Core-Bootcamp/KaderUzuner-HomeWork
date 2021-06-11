using HomeWork.Domain.Interfaces;
using HomeWork.Domain.Models;
using HomeWork.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Infrastructure.Data.Repository
{
    public class FoodRepository : Repository<Food>, IFoodRepository
    {
        public FoodRepository(HomeWorkDbContext context) : base(context)
        {
        }

    }
}