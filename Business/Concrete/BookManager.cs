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
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public Book Get(Expression<Func<Book, bool>> filter)
        {
            return _bookDal.Get(filter);
        }

        public List<BookDetail> GetBookDetailList()
        {
            return _bookDal.GetBookDetailList();
        }

        public List<Book> GetList(Expression<Func<Book, bool>> filter = null)
        {
            return _bookDal.GetList(filter);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
