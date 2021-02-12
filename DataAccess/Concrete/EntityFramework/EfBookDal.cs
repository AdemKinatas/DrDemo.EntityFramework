using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, DrDemoContext>, IBookDal
    {
        public List<BookDetail> GetBookDetailList()
        {
            using (var context = new DrDemoContext())
            {
                var result = from b in context.Books
                             //join c in context.Categories on b.CategoryId equals c.Id
                             //join p in context.Publishers on b.PublisherId equals p.Id
                             //join a in context.Authors on b.AuthorId equals a.Id
                             select new BookDetail()
                             {
                                 BookName=b.BookName,
                                 //CategoryName=c.CategoryName,
                                 //AuthorName = a.AuthorName,
                                 //PublisherName = p.PublisherName,
                                 CategoryName =b.Category.CategoryName,
                                 AuthorName =b.Author.AuthorName,
                                 PublisherName=b.Publisher.PublisherName,
                                 Summary =b.Summary,
                                 AmountSold=b.AmountSold,
                                 UnitPrice=b.UnitPrice
                             };
                return result.ToList();
            }
        }
    }
}
