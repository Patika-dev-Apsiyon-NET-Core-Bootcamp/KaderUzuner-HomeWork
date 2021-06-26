using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Domain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public ICollection<Food> Foods { get; set; }
    }
}
