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
    public interface IAuthorDal: IEntityRepository<Author>
    {
        List<AuthorDetail> GetAuthorDetails(Expression<Func<Author, bool>> filter = null);
    }
}
