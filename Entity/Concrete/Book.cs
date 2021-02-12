using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Summary { get; set; }
        public DateTime PublishDate { get; set; }
        public int AmountSold { get; set; }
        public decimal UnitPrice { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }

        public virtual List<Shop> Shops { get; set; }
    }
}
