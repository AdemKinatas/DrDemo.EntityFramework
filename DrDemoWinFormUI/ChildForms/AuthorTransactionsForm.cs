using Business.Abstract;
using Business.Concrete;
using Business.Messages;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
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
    public partial class AuthorTransactionsForm : Form
    {
        IAuthorService _authorManager;
        public AuthorTransactionsForm()
        {
            InitializeComponent();
            _authorManager = new AuthorManager(new EfAuthorDal());
        }
        private void AuthorListForm_Load(object sender, EventArgs e)
        {
            GetAuthors();
        }

        private void GetAuthors()
        {
            lvwAuthorsList.Items.Clear();
            foreach (Author author in _authorManager.GetList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = author.Id.ToString();
                lvi.SubItems.Add(author.AuthorName);
                lvi.SubItems.Add(author.BirthDate.ToShortDateString());
                lvi.SubItems.Add(author.Biography);
                lvi.Tag = author;
                lvwAuthorsList.Items.Add(lvi);
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor();
            GetAuthors();
        }
        public void AddAuthor()
        {
            Author author = new Author();
            author.AuthorName = txtAuthorName.Text;
            author.BirthDate = dpAuthorBirthDay.Value;
            author.Biography = rtxtAuthorBiography.Text;

            _authorManager.Add(author);
            MessageBox.Show(AuthorMessage.AddMessage());
        }

        Author _selectedAuthor;
        private void listView1_Click(object sender, EventArgs e)
        {
            _selectedAuthor = (Author)lvwAuthorsList.SelectedItems[0].Tag;

            txtAuthorName.Text = _selectedAuthor.AuthorName;
            dpAuthorBirthDay.Value = _selectedAuthor.BirthDate;
            rtxtAuthorBiography.Text = _selectedAuthor.Biography;
        }

        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
            UpdateAuthor();

            GetAuthors();
        }

        private void UpdateAuthor()
        {
            _selectedAuthor.AuthorName = txtAuthorName.Text;
            _selectedAuthor.BirthDate = dpAuthorBirthDay.Value;
            _selectedAuthor.Biography = rtxtAuthorBiography.Text;
            _authorManager.Update(_selectedAuthor);

            MessageBox.Show(AuthorMessage.UpdateMessage());
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            DeleteAuthor();
            GetAuthors();
        }

        private void DeleteAuthor()
        {
            _authorManager.Delete(_selectedAuthor);

            MessageBox.Show(AuthorMessage.DeleteMessage());
        }
    }
}
