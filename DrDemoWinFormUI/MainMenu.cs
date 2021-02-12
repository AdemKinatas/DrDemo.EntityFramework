using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DrWinFormUI.ChildForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrWinFormUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        void ChildForm(Form _childForm)
        {
            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == _childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }

        private void yazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AuthorTransactionsForm());
        }

        private void kitapToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new BookTransactionsForm());
        }

        private void kategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new CategoryTransactionsForm());
        }

        private void yayınEviİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new PublisherTransactionsForm());
        }

        private void kitapçıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new ShopTransactionsForm());
        }

        private void testİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new TestForm());
        }
    }
}
