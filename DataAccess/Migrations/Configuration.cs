namespace DataAccess.Migrations
{
    using Entity.Concrete;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.Concrete.EntityFramework.Context.DrDemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataAccess.Concrete.EntityFramework.Context.DrDemoContext context)
        {
            if (!context.Authors.Any())
            {
                List<Author> authors = new List<Author>()
                {
                    new Author{ AuthorName="Oğuz Atay", BirthDate=DateTime.Parse("1934-10-12"), Biography="Türk edebiyatının usta kalemi"},
                    new Author{ AuthorName="İhsan Oktay Anar", BirthDate=DateTime.Parse("1960-10-12"), Biography="Türk edebiyatının yeni nesil usta kalemi"},
                    new Author{ AuthorName="Cahit Zarifoğlu", BirthDate=DateTime.Parse("1940-10-12"), Biography="Türk şiirinin zarif şairi"},
                    new Author{ AuthorName="Yaşar Kemal", BirthDate=DateTime.Parse("1925-10-12"), Biography="Türk edebiyatının usta kalemi"},
                };

                context.Authors.AddRange(authors);
                context.SaveChanges();
            }

            if (!context.Categories.Any())
            {
                List<Category> categories = new List<Category>()
                {
                    new Category{ CategoryName="Kitap"},
                    new Category{ CategoryName="Edebiyat", ParentId=1},
                    new Category{ CategoryName="Tarih", ParentId=1},
                    new Category{ CategoryName="Roman", ParentId=2},
                    new Category{ CategoryName="Şiir", ParentId=2}
                };

                context.Categories.AddRange(categories);
                context.SaveChanges();
            }

            if (!context.Publishers.Any())
            {
                List<Publisher> publishers = new List<Publisher>()
                {
                    new Publisher{ PublisherName="Can Yayınları", EMail="can@yayinlari.com", Address="İstanbul", PhoneNumber="02164448855"},
                    new Publisher{ PublisherName="İletişim Yayınları", EMail="iletisim@yayinlari.com", Address="İstanbul", PhoneNumber="02164445588"},
                    new Publisher{ PublisherName="İş Bankası Yayınları", EMail="isbankasi@yayinlari.com", Address="İstanbul", PhoneNumber="02164441122"},
                };

                context.Publishers.AddRange(publishers);
                context.SaveChanges();
            }

            if (!context.Shops.Any())
            {
                List<Shop> shops = new List<Shop>()
                {
                    new Shop{ ShopName="D&R Maltepe", Email="maltepe@dr.com", Address="İstanbul", PhoneNumber="02169997755"},
                    new Shop{ ShopName="D&R Kadıköy", Email="kadiköy@dr.com", Address="İstanbul", PhoneNumber="02169995577"},
                };

                context.Shops.AddRange(shops);
                context.SaveChanges();
            }

            if (!context.Books.Any())
            {
                List<Book> books = new List<Book>()
                {
                    new Book{ BookName="Tutunamayanlar", AuthorId=1, PublisherId=1, CategoryId=4, AmountSold=250000, PublishDate=DateTime.Parse("2020-10-11"), UnitPrice=50, Summary="Mükemmel bir Kitap",ImageUrl="1.jpg"},
                    new Book{ BookName="Tehlikeli Oyunlar", AuthorId=1, PublisherId=2, CategoryId=4, AmountSold=300000, PublishDate=DateTime.Parse("2019-10-11"), UnitPrice=45, Summary="Mükemmel bir Kitap",ImageUrl="2.jpg"},
                    new Book{ BookName="Suskunlar", AuthorId=2, PublisherId=1, CategoryId=4, AmountSold=150000, PublishDate=DateTime.Parse("2018-08-11"), UnitPrice=50, Summary="Güzel bir Kitap",ImageUrl="3.jpg"},
                };

                context.Books.AddRange(books);
                context.SaveChanges();
            }
        }
    }
}
