using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class AppUserAndRole:IEntity
    {
        public int AppUserId { get; set; }
        public int RoleId { get; set; }

        public AppUser AppUser { get; set; }
        public Role Role { get; set; }
    }
}
