using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class CategoryDal : ICategoryDal
	{
		List<Category> _categories;
        public CategoryDal()
        {
			_categories = new List<Category>();
            
        }
        public void Add(Category category)
		{
			_categories.Add(category);
		}

		public void Delete(Category category)
		{
			_categories.Remove(category);
		}

		public List<Category> GetAll()
		{
			return _categories;
		}

		public void Update(Category category)
		{
			Category existCategory = _categories.Find(x => x.Id == category.Id);

			if (existCategory is null)
			
				return;
				existCategory.CategoryName = category.CategoryName; 

			
		}
	}
}
