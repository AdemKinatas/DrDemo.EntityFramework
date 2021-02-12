using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PublisherManager : IPublisherService
    {
        IPublisherDal _publisherDal;

        public PublisherManager(IPublisherDal publisherDal)
        {
            _publisherDal = publisherDal;
        }

        public void Add(Publisher publisher)
        {
            _publisherDal.Add(publisher);
        }

        public void Delete(Publisher publisher)
        {
            _publisherDal.Delete(publisher);
        }

        public Publisher Get(Expression<Func<Publisher, bool>> filter)
        {
            return _publisherDal.Get(filter);
        }

        public List<Publisher> GetList(Expression<Func<Publisher, bool>> filter = null)
        {
            return _publisherDal.GetList(filter);
        }

        public void Update(Publisher publisher)
        {
            _publisherDal.Update(publisher);
        }
    }
}
