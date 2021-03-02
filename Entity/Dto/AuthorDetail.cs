using Core.Entity.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class AuthorDetail:IDto
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Biography { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
