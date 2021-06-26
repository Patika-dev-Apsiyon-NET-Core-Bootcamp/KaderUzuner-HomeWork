using System.Collections.Generic;
using System.Linq;
using BookInSession.Models;

namespace BookInSession.Database
{
    public class Categories
    {
        private List<CategoryViewModel> _categories;

        public Categories()
        {
            _categories = new List<CategoryViewModel>()
            {
                new CategoryViewModel(){CategoryId=1, CategoryName = "Polisiye Roman"},
                new CategoryViewModel(){CategoryId=2, CategoryName = "Dünya Klasikleri"},
                new CategoryViewModel(){CategoryId=3, CategoryName = "Yerli"},
            };
        }
        public List<CategoryViewModel> GetAll()
        {
            return _categories;
        }
        
        public CategoryViewModel GetById(int categoryId)
        {
            return _categories.SingleOrDefault(b=>b.CategoryId == categoryId);
        }
        

        public void Add(CategoryViewModel categoryModel)
        {
            _categories.Add(categoryModel);
        }

      
        
    }
}