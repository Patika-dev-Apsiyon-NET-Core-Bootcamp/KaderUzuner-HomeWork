using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Domain.Models
{
    public class Food : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

       public ICollection<Category> Categories { get; set; }

    }
}
