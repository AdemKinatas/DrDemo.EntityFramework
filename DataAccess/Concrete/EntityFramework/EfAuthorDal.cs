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
    public class EfAuthorDal : EfEntityRepositoryBase<Author, DrDemoContext>, IAuthorDal
    {
        public List<AuthorDetail> GetAuthorDetails(Expression<Func<Author, bool>> filter = null)
        {
            if (filter==null)
            {
                using (var context = new DrDemoContext())
                {
                    var authors = context.Authors.Select(x => new AuthorDetail
                    {
                        AuthorId=x.Id,
                        AuthorName=x.AuthorName,
                        Biography=x.Biography,
                        BirthDate=x.BirthDate,
                        Books=x.Books
                    }).ToList();

                    return authors;
                }
            }
            else
            {
                using (var context = new DrDemoContext())
                {
                    var authors = context.Authors.Where(filter).Select(x => new AuthorDetail
                    {
                        AuthorId = x.Id,
                        AuthorName = x.AuthorName,
                        Biography = x.Biography,
                        BirthDate = x.BirthDate,
                        Books = x.Books
                    }).ToList();

                    return authors;
                }
            }
        }
    }
}
