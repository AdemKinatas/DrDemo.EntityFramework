using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class BookDetail:IDto
    {
        public string BookName { get; set; }
        public string CategoryName { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public string Summary { get; set; }
        public int AmountSold { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
