using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class DrDemoContext : DbContext
    {
        public DrDemoContext() : base("DrDemoContext")
        {

        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AppUserAndRole> AppUserAndRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().Property(a => a.AuthorName).IsRequired();
            modelBuilder.Entity<Author>().Property(a => a.AuthorName).HasMaxLength(100);
            modelBuilder.Entity<Author>().Property(a => a.Biography).IsRequired();
            modelBuilder.Entity<Author>().Property(a => a.Biography).HasMaxLength(1500);

            modelBuilder.Entity<Book>().Property(b => b.BookName).IsRequired();
            modelBuilder.Entity<Book>().Property(b => b.BookName).HasMaxLength(250);
            modelBuilder.Entity<Book>().Property(b => b.Summary).IsRequired();
            modelBuilder.Entity<Book>().Property(b => b.Summary).HasMaxLength(1500);

            modelBuilder.Entity<Category>().Property(c => c.CategoryName).IsRequired();
            modelBuilder.Entity<Category>().Property(c => c.CategoryName).HasMaxLength(100);

            modelBuilder.Entity<Publisher>().Property(p => p.PublisherName).IsRequired();
            modelBuilder.Entity<Publisher>().Property(p => p.PublisherName).HasMaxLength(100);
            modelBuilder.Entity<Publisher>().Property(p => p.Address).IsRequired();
            modelBuilder.Entity<Publisher>().Property(p => p.Address).HasMaxLength(100);
            modelBuilder.Entity<Publisher>().Property(p => p.EMail).IsRequired();
            modelBuilder.Entity<Publisher>().Property(p => p.EMail).HasMaxLength(100);
            modelBuilder.Entity<Publisher>().Property(p => p.PhoneNumber).IsRequired();
            modelBuilder.Entity<Publisher>().Property(p => p.PhoneNumber).HasMaxLength(13);

            modelBuilder.Entity<Shop>().Property(p => p.ShopName).IsRequired();
            modelBuilder.Entity<Shop>().Property(p => p.ShopName).HasMaxLength(100);
            modelBuilder.Entity<Shop>().Property(p => p.Address).IsRequired();
            modelBuilder.Entity<Shop>().Property(p => p.Address).HasMaxLength(500);
            modelBuilder.Entity<Shop>().Property(p => p.Email).IsRequired();
            modelBuilder.Entity<Shop>().Property(p => p.Email).HasMaxLength(100);
            modelBuilder.Entity<Shop>().Property(p => p.PhoneNumber).IsRequired();
            modelBuilder.Entity<Shop>().Property(p => p.PhoneNumber).HasMaxLength(13);


            modelBuilder.Entity<Category>().HasOptional(c => c.Parent).WithMany(c => c.Children);

            modelBuilder.Entity<Book>()
            .HasRequired<Author>(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.AuthorId);

            modelBuilder.Entity<Book>()
            .HasRequired<Publisher>(b => b.Publisher)
            .WithMany(p => p.Books)
            .HasForeignKey(b => b.PublisherId);

            //modelBuilder.Entity<Book>()
            //.HasRequired<Category>(b => b.Category)
            //.WithMany(c => c.Books)
            //.HasForeignKey(b => b.CategoryId);

            modelBuilder.Entity<Category>().HasMany(c => c.Books).WithRequired(x => x.Category).HasForeignKey(b => b.CategoryId);

            modelBuilder.Entity<Book>().HasMany(b => b.Shops).WithMany(s => s.Books).Map(map =>
            {
                map.ToTable("BookShops");
                map.MapLeftKey("BookId");
                map.MapRightKey("ShopId");
            });

            modelBuilder.Entity<AppUserAndRole>().HasKey(x => new { x.AppUserId, x.RoleId });
        }
    }
}
