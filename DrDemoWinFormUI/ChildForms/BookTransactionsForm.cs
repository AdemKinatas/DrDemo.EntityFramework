using Business.Abstract;
using Business.Concrete;
using Business.Messages;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrWinFormUI.ChildForms
{
    public partial class BookTransactionsForm : Form
    {
        IBookService _bookManager;
        IAuthorService _authorManager;
        ICategoryService _categoryManager;
        IPublisherService _publisherManager;

        public BookTransactionsForm()
        { 
            InitializeComponent();
            _bookManager = new BookManager(new EfBookDal());
            _authorManager = new AuthorManager(new EfAuthorDal());
            _categoryManager = new CategoryManager(new EfCategoryDal());
            _publisherManager = new PublisherManager(new EfPublisherDal());
        }

        private void BookForm_Load(object sender, EventArgs e)
        {           
            GetBooks();
        }

        private void GetBooks()
        {
            lvwBooksList.Items.Clear();
            cmbBookAuthor.DisplayMember = "AuthorName";
            cmbBookAuthor.DataSource = _authorManager.GetList();
            cmbBookCategory.DisplayMember = "CategoryName";
            cmbBookCategory.DataSource = _categoryManager.GetList();
            cmbBookPublisher.DisplayMember = "PublisherName";
            cmbBookPublisher.DataSource = _publisherManager.GetList();

            foreach (Book book in _bookManager.GetList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = book.BookName;
                lvi.SubItems.Add(book.AuthorId.ToString());
                lvi.SubItems.Add(book.PublisherId.ToString());
                lvi.SubItems.Add(book.CategoryId.ToString());
                lvi.SubItems.Add(book.UnitPrice.ToString());
                lvi.SubItems.Add(book.Summary);

                lvi.Tag = book;
                lvwBooksList.Items.Add(lvi);
            }
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.BookName = txtBookName.Text;
            book.AuthorId = ((Author)cmbBookAuthor.SelectedItem).Id;
            book.CategoryId = ((Category)cmbBookCategory.SelectedItem).Id;
            book.PublisherId = ((Publisher)cmbBookPublisher.SelectedItem).Id;
            book.Summary = rtxtSummary.Text;
            book.PublishDate = dpPublishedDate.Value;
            book.UnitPrice = nudUnitPrice.Value;
            book.AmountSold = Convert.ToInt32(nudAmountSold.Value);

            _bookManager.Add(book);
            MessageBox.Show(BookMessage.AddMessage());

            GetBooks();
        }

        Book _selectedBook;
        private void lvwBooksList_Click(object sender, EventArgs e)
        {
            _selectedBook = (Book)lvwBooksList.SelectedItems[0].Tag;

            txtBookName.Text = _selectedBook.BookName;
            cmbBookAuthor.Text = _authorManager.Get(a => a.Id == _selectedBook.AuthorId).AuthorName;
            cmbBookCategory.Text = _categoryManager.Get(c => c.Id == _selectedBook.CategoryId).CategoryName;
            cmbBookPublisher.Text = _publisherManager.Get(p => p.Id == _selectedBook.PublisherId).PublisherName;
            nudAmountSold.Value = _selectedBook.AmountSold;
            nudUnitPrice.Value = _selectedBook.UnitPrice;
            rtxtSummary.Text = _selectedBook.Summary;
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            _selectedBook.BookName = txtBookName.Text;
            Author author = (Author)cmbBookAuthor.SelectedItem;
            _selectedBook.AuthorId = author.Id;
            Category category = (Category)cmbBookCategory.SelectedItem;
            _selectedBook.CategoryId = category.Id;
            Publisher publisher= (Publisher)cmbBookPublisher.SelectedItem;
            _selectedBook.PublisherId = publisher.Id;
            _selectedBook.AmountSold = Convert.ToInt32(nudAmountSold.Value);
            _selectedBook.UnitPrice = nudUnitPrice.Value;
            _selectedBook.Summary = rtxtSummary.Text;

            _bookManager.Update(_selectedBook);
            MessageBox.Show(BookMessage.UpdateMessage());
            GetBooks();
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            _bookManager.Delete(_selectedBook);
            MessageBox.Show(BookMessage.DeleteMessage());
            GetBooks();
        }
    }
}
