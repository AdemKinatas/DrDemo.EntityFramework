using Core.DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        List<CategoryDetail> GetCategoryDetails(Expression<Func<Category, bool>> filter = null);
    }
}
