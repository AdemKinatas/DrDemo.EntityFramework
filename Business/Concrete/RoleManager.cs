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
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void Add(Role role)
        {
            _roleDal.Add(role);
        }

        public void Delete(Role role)
        {
            _roleDal.Delete(role);
        }

        public Role Get(Expression<Func<Role, bool>> filter)
        {
            return _roleDal.Get(filter);
        }

        public List<Role> GetList(Expression<Func<Role, bool>> filter = null)
        {
            return _roleDal.GetList(filter);
        }

        public void Update(Role role)
        {
            _roleDal.Update(role);
        }
    }
}
