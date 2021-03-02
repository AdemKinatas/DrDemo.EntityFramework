using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, DrDemoContext>, ICategoryDal
    {
        public List<CategoryDetail> GetCategoryDetails(Expression<Func<Category, bool>> filter = null)
        {
            if (filter==null)
            {
                var context = new DrDemoContext();

                var result = context.Categories.Select(x => new CategoryDetail
                {
                    CategoryId = x.Id,
                    CategoryName = x.CategoryName,
                    Parent = x.Parent,
                    Children = x.Children
                }).ToList();

                return result;
            }
            else
            {
                var context = new DrDemoContext();

                var result = context.Categories.Where(filter).Select(x => new CategoryDetail
                {
                    CategoryId = x.Id,
                    CategoryName = x.CategoryName,
                    Parent = x.Parent,
                    Children = x.Children
                }).ToList();

                return result;
            }
        }
    }
}
