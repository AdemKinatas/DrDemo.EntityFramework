using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Publisher:IEntity
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
