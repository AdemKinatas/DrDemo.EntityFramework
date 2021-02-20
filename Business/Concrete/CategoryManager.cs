using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.Get(filter);
        }

        public List<CategoryDetail> GetCategoryDetails(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryDal.GetCategoryDetails(); 
        }

        public List<Category> GetList(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryDal.GetList(filter);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
