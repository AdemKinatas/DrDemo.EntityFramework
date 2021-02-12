using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Biography { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
