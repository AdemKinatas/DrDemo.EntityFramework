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
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        public void Delete(Author author)
        {
            _authorDal.Delete(author);
        }

        public Author Get(Expression<Func<Author, bool>> filter)
        {
            return _authorDal.Get(filter);
        }

        public List<AuthorDetail> GetAuthorDetails(Expression<Func<Author, bool>> filter = null)
        {
            return _authorDal.GetAuthorDetails(filter);
        }

        public List<Author> GetList(Expression<Func<Author, bool>> filter = null)
        {
            return _authorDal.GetList(filter);
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }
    }
}
