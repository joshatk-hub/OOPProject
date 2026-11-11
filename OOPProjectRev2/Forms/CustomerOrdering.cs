using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPProjectRev2.Models;
using OOPProjectRev2.Services;

namespace OOPProjectRev2
{
    public partial class CustomerOrdering : Form
    {
        private readonly IDataRepository _datastore;
        public CustomerOrdering()
        {
            InitializeComponent();
            _datastore = new DataStore();
        }
        public void GetMenuItems()
        {
            listViewItems.Items.Clear();

            foreach (var item in _datastore.LoadRegularMenuItems())
            {
                AddMenuItemToListView(item);
            }

            DateOnly today = DateOnly.FromDateTime(DateTime.Today);

            foreach (var item in _datastore.LoadSeasonalMenuItems())
            {
                DateOnly seasonStart = DateOnly.Parse(item.SeasonStart);
                DateOnly seasonEnd = DateOnly.Parse(item.SeasonEnd);

                if (today >= seasonStart && today <= seasonEnd)
                {
                    AddMenuItemToListView(item);
                }
            }
        }
        private void AddMenuItemToListView(MenuItem item)
        {
            ListViewItem listViewItem = new ListViewItem(item.Name);
            listViewItem.SubItems.Add(item.Category);
            listViewItem.SubItems.Add(item.Price.ToString("C"));
            listViewItems.Items.Add(listViewItem);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CustomerAccount customerAccount = new CustomerAccount();
            customerAccount.Show();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OrderInfo orderInfo = new OrderInfo();
            orderInfo.Show();
        }
        private void CustomerOrdering_Load(object sender, EventArgs e)
        {
            GetMenuItems();
        }
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedItem == null) return;
            string selectedCategory = comboBoxCategory.SelectedItem.ToString();
            listViewItems.BeginUpdate();
            listViewItems.Items.Clear();
            if (selectedCategory == "All")
            {
                GetMenuItems();
            }
            else
            {
                // Safely filter menu items using LINQ instead of unsafe nested index matching loops
                var filteredItems = _datastore.LoadRegularMenuItems()
                    .Where(item => item.Category == selectedCategory);

                foreach (var item in filteredItems)
                {
                    ListViewItem listViewItem = new ListViewItem(item.Name);
                    listViewItem.SubItems.Add(item.Category);
                    listViewItem.SubItems.Add(item.Price.ToString("C"));
                    listViewItems.Items.Add(listViewItem);
                }
            }
            listViewItems.EndUpdate();
        }
        private void buttonAddCart_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to add to the cart.");
                return;
            }
            var item = listViewItems.SelectedItems[0];
            if (item != null)
            {
                string itemName = item.SubItems[0].Text;
                var menuItem = _datastore.LoadRegularMenuItems().FirstOrDefault(i => i.Name == itemName) ??
                               _datastore.LoadSeasonalMenuItems().FirstOrDefault(i => i.Name == itemName);
                if (menuItem != null)
                {
                    Cart cart = _datastore.LoadCart();
                    cart.AddItem(menuItem, 1);
                    _datastore.SaveCart(cart);
                }
            }
        }
    }
}