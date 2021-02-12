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
    public partial class CategoryTransactionsForm : Form
    {
        ICategoryService _categoryManager;
        public CategoryTransactionsForm()
        {
            InitializeComponent();
            _categoryManager = new CategoryManager(new EfCategoryDal());
        }
        private void CategoryTransactionsForm_Load(object sender, EventArgs e)
        {
            GetCategories();
        }

        private void GetCategories()
        {
            lvwCategoryList.Items.Clear();
            cmbParentCategory.Items.Clear();
            cmbParentCategory.DisplayMember = "CategoryName";
            cmbParentCategory.Items.Add("");

            foreach (Category category in _categoryManager.GetList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = category.Id.ToString();
                lvi.SubItems.Add(category.CategoryName);
                lvi.SubItems.Add(category.ParentId.ToString());
                lvi.SubItems.Add(category.IsActive.ToString());
                lvi.SubItems.Add(category.IsPopular.ToString());
                lvi.SubItems.Add(category.AddedAt.ToShortDateString());
                lvi.Tag = category;
                lvwCategoryList.Items.Add(lvi);

                cmbParentCategory.Items.Add(category);
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddCategory();
            GetCategories();
        }

        private void AddCategory()
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            if (cmbParentCategory.SelectedItem != null)
            {
                category.ParentId = ((Category)cmbParentCategory.SelectedItem).Id;
            }
            else
            {
                category.ParentId = null;
            }
            category.IsActive = cbNotActive.Checked ? false : true;
            category.IsPopular = cbNotPopuler.Checked ? false : true;
            category.AddedAt = dpAddedDate.Value;

            _categoryManager.Add(category);

            MessageBox.Show(CategoryMessage.AddMessage());
        }

        Category selectedCategory;
        private void lvwCategoryList_Click(object sender, EventArgs e)
        {
            selectedCategory = (Category)lvwCategoryList.SelectedItems[0].Tag;
            txtCategoryName.Text = selectedCategory.CategoryName;
            cmbParentCategory.SelectedItem = selectedCategory.Parent;
            dpAddedDate.Value = selectedCategory.AddedAt;
            if (selectedCategory.IsActive)
            {
                cbActive.Checked = true;
                cbNotActive.Checked = false;
            }
            else
            {
                cbActive.Checked = false;
                cbNotActive.Checked = true;
            }

            if (selectedCategory.IsPopular)
            {
                cbPopuler.Checked = true;
                cbNotPopuler.Checked = false;
            }
            else
            {
                cbPopuler.Checked = false;
                cbNotPopuler.Checked = true;
            }
        }
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            UpdateCategory();
            GetCategories();
        }

        private void UpdateCategory()
        {
            selectedCategory.ParentId = null;
            selectedCategory.Parent = null;
            selectedCategory.CategoryName = txtCategoryName.Text;
            if (cmbParentCategory.SelectedItem.ToString() == "")
            {
                selectedCategory.ParentId = null;
            }
            else
            {
                selectedCategory.ParentId = ((Category)cmbParentCategory.SelectedItem).Id;
            }
            selectedCategory.AddedAt = dpAddedDate.Value;
            if (cbNotActive.Checked)
            {
                selectedCategory.IsActive = false;
            }
            else
            {
                selectedCategory.IsActive = true;
            }

            if (cbNotPopuler.Checked)
            {
                selectedCategory.IsPopular = false;
            }
            else
            {
                selectedCategory.IsPopular = true;
            }

            _categoryManager.Update(selectedCategory);

            MessageBox.Show(CategoryMessage.UpdateMessage());
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            NewMethod();
            GetCategories();
        }

        private void NewMethod()
        {
            _categoryManager.Delete(selectedCategory);
            MessageBox.Show(CategoryMessage.DeleteMessage());
        }
    }
}
