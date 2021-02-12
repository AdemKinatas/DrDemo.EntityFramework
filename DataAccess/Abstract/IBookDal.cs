using Core.DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBookDal : IEntityRepository<Book>
    {
        List<BookDetail> GetBookDetailList();
    }
}
