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
    public partial class ShopTransactionsForm : Form
    {
        IShopService _shopManager;
        public ShopTransactionsForm()
        {
            InitializeComponent();
            _shopManager = new ShopManager(new EfShopDal());
        }

        private void ShopTransactionsForm_Load(object sender, EventArgs e)
        {
            GetShops();
        }

        private void GetShops()
        {
            lvwShopList.Items.Clear();
            foreach (Shop shop in _shopManager.GetList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = shop.Id.ToString();
                lvi.SubItems.Add(shop.ShopName);
                lvi.SubItems.Add(shop.PhoneNumber);
                lvi.SubItems.Add(shop.Email);
                lvi.SubItems.Add(shop.Address);
                lvi.Tag = shop;
                lvwShopList.Items.Add(lvi);
            }
        }

        private void btnAddShop_Click(object sender, EventArgs e)
        {
            AddShop();
            GetShops();
        }

        private void AddShop()
        {
            Shop shop = new Shop();
            shop.ShopName = txtShopName.Text;
            shop.PhoneNumber = txtShopPhoneNumber.Text;
            shop.Email = txtShopEmail.Text;
            shop.Address = rtxtShopAddress.Text;

            _shopManager.Add(shop);
            MessageBox.Show(ShopMessage.AddMessage());
        }

        Shop _selectedShop;
        private void lvwShopList_Click(object sender, EventArgs e)
        {
            _selectedShop = (Shop)lvwShopList.SelectedItems[0].Tag;

            txtShopName.Text = _selectedShop.ShopName;
            txtShopPhoneNumber.Text = _selectedShop.PhoneNumber;
            txtShopEmail.Text = _selectedShop.Email;
            rtxtShopAddress.Text = _selectedShop.Address;
        }


        private void btnUpdateShop_Click(object sender, EventArgs e)
        {
            UpdateShop();
            GetShops();
        }

        private void UpdateShop()
        {
            _selectedShop.ShopName = txtShopName.Text;
            _selectedShop.PhoneNumber = txtShopPhoneNumber.Text;
            _selectedShop.Email = txtShopEmail.Text;
            _selectedShop.Address = rtxtShopAddress.Text;

            _shopManager.Update(_selectedShop);
            MessageBox.Show(ShopMessage.UpdateMessage());
        }

        private void btnDeleteShop_Click(object sender, EventArgs e)
        {
            DeleteShop();
            GetShops();
        }

        private void DeleteShop()
        {
            _shopManager.Delete(_selectedShop);
            MessageBox.Show(ShopMessage.DeleteMessage());
        }
    }
}

