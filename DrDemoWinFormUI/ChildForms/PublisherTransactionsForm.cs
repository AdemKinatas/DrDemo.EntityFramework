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
    public partial class PublisherTransactionsForm : Form
    {
        IPublisherService _publisherManager;
        public PublisherTransactionsForm()
        {
            InitializeComponent();
            _publisherManager = new PublisherManager(new EfPublisherDal());
        }

        private void PublisherTransactionsForm_Load(object sender, EventArgs e)
        {
            GetPublishers();
        }

        private void GetPublishers()
        {
            lvwPublisherList.Items.Clear();
            foreach (Publisher publisher in _publisherManager.GetList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = publisher.Id.ToString();
                lvi.SubItems.Add(publisher.PublisherName);
                lvi.SubItems.Add(publisher.PhoneNumber);
                lvi.SubItems.Add(publisher.EMail);
                lvi.SubItems.Add(publisher.Address);
                lvi.Tag = publisher;
                lvwPublisherList.Items.Add(lvi);
            }
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            AddPublisher();
            GetPublishers();
        }

        private void AddPublisher()
        {
            Publisher publisher = new Publisher();
            publisher.PublisherName = txtPublisherName.Text;
            publisher.PhoneNumber = txtPublisherPhoneNumber.Text;
            publisher.EMail = txtPublisherEmail.Text;
            publisher.Address = rtxtPublisherAddress.Text;

            _publisherManager.Add(publisher);
            MessageBox.Show(PublisherMessage.AddMessage());
        }

        Publisher _selectedPublisher;
        private void btnUpdatePublisher_Click(object sender, EventArgs e)
        {
            UpdatePublisher();
            GetPublishers();
        }

        private void UpdatePublisher()
        {
            _selectedPublisher.PublisherName = txtPublisherName.Text;
            _selectedPublisher.PhoneNumber = txtPublisherPhoneNumber.Text;
            _selectedPublisher.EMail = txtPublisherEmail.Text;
            _selectedPublisher.Address = rtxtPublisherAddress.Text;

            _publisherManager.Update(_selectedPublisher);
            MessageBox.Show(PublisherMessage.UpdateMessage());
        }

        private void lvwPublisherList_Click(object sender, EventArgs e)
        {
            _selectedPublisher = (Publisher)lvwPublisherList.SelectedItems[0].Tag;

            txtPublisherName.Text = _selectedPublisher.PublisherName;
            txtPublisherPhoneNumber.Text = _selectedPublisher.PhoneNumber;
            txtPublisherEmail.Text = _selectedPublisher.EMail;
            rtxtPublisherAddress.Text = _selectedPublisher.Address;
        }

        private void btnDeletePublisher_Click(object sender, EventArgs e)
        {
            DeletePublisher();
            GetPublishers();
        }

        private void DeletePublisher()
        {
            _publisherManager.Delete(_selectedPublisher);
            MessageBox.Show(PublisherMessage.DeleteMessage());
        }
    }
}
