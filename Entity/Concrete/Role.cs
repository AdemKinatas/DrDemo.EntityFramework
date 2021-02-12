using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Role: IEntity
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual List<AppUserAndRole> AppUserAndRoles { get; set; }
    }
}
