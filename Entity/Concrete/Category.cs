using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Category : IEntity
    {
        public Category()
        {
            IsPopular = false;
            IsActive = true;
            AddedAt = DateTime.Now;
            Books = new List<Book>();
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int? ParentId { get; set; }
        public virtual Category Parent { get; set; }
        public virtual List<Category> Children { get; set; }
        public bool IsPopular { get; set; }
        public DateTime AddedAt { get; set; }
        public bool IsActive { get; set; }
        public List<Book> Books { get; set; }
    }
}
