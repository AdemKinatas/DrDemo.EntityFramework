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
    public class EfBookDal : EfEntityRepositoryBase<Book, DrDemoContext>, IBookDal
    {
        public List<BookDetail> GetBookDetailList(Expression<Func<Book, bool>> filter = null)
        {
            if (filter!=null)
            {
                using (var context = new DrDemoContext())
                {
                    var result = from b in context.Books.Where(filter)
                                 select new BookDetail()
                                 {
                                     BookId = b.Id,
                                     BookName = b.BookName,
                                     CategoryName = b.Category.CategoryName,
                                     AuthorName = b.Author.AuthorName,
                                     PublisherName = b.Publisher.PublisherName,
                                     Summary = b.Summary,
                                     AmountSold = b.AmountSold,
                                     UnitPrice = b.UnitPrice,
                                     ImageUrl = b.ImageUrl
                                 };
                    return result.ToList();
                }
            }
            else
            {
                using (var context = new DrDemoContext())
                {
                    var result = from b in context.Books
                                 select new BookDetail()
                                 {
                                     BookId = b.Id,
                                     BookName = b.BookName,
                                     CategoryName = b.Category.CategoryName,
                                     AuthorName = b.Author.AuthorName,
                                     PublisherName = b.Publisher.PublisherName,
                                     Summary = b.Summary,
                                     AmountSold = b.AmountSold,
                                     UnitPrice = b.UnitPrice,
                                     ImageUrl = b.ImageUrl
                                 };
                    return result.ToList();
                }
            }          
        }
    }
}
