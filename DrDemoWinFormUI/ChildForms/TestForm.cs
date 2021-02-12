using Business.Abstract;
using Business.Concrete;
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
    public partial class TestForm : Form
    {
        ICategoryService _categoryService;
        public TestForm()
        {
            InitializeComponent();
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            var category = _categoryService.Get(c => c.Id == 3);
            dataGridView1.DataSource = category.Books.ToList();
        }
    }
}
