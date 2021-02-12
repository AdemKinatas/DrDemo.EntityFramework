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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void Add(AppUser appUser)
        {
            _appUserDal.Add(appUser);
        }

        public void Delete(AppUser appUser)
        {
            _appUserDal.Delete(appUser);
        }

        public AppUser Get(Expression<Func<AppUser, bool>> filter)
        {
            return _appUserDal.Get(filter);
        }

        public List<AppUser> GetList(Expression<Func<AppUser, bool>> filter = null)
        {
            return _appUserDal.GetList(filter);
        }

        public void Update(AppUser appUser)
        {
            _appUserDal.Update(appUser);
        }
    }
}
