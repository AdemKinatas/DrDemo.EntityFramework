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
    public class ShopManager : IShopService
    {
        IShopDal _shopDal;

        public ShopManager(IShopDal shopDal)
        {
            _shopDal = shopDal;
        }

        public void Add(Shop shop)
        {
            _shopDal.Add(shop);
        }

        public void Delete(Shop shop)
        {
            _shopDal.Delete(shop);
        }

        public Shop Get(Expression<Func<Shop, bool>> filter)
        {
            return _shopDal.Get(filter);
        }

        public List<Shop> GetList(Expression<Func<Shop, bool>> filter = null)
        {
            return _shopDal.GetList(filter);
        }

        public void Update(Shop shop)
        {
            _shopDal.Update(shop);
        }
    }
}
