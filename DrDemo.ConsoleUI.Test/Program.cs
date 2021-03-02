using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrDemo.ConsoleUI.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DrDemoContext db = new DrDemoContext();

            var authors = db.Authors.Select(x => new
            {
                x.Id,
                x.AuthorName,
                x.BirthDate,
                x.Biography,
                x.Books
            }).ToList();
            foreach (var author in authors)
            {
                foreach (var book in author.Books)
                {
                    Console.WriteLine(book.BookName);
                }
            }


            //var categories = db.Categories.Select(c => new
            //{
            //    c.Parent,
            //    c.CategoryName,
            //    c.Children
            //}).ToList();

            //foreach (var category in categories)
            //{
            //    if (category.Parent == null)
            //    {
            //        Console.WriteLine(category.CategoryName);

            //        foreach (var child in category.Children)
            //        {
            //            Console.WriteLine("--" + child.CategoryName);
            //            foreach (var item in child.Children)
            //            {
            //                Console.WriteLine("----" + item.CategoryName);
            //            }
            //        }
            //    }
            //}

            Console.ReadLine();
        }
    }
}
