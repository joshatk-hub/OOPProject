using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPProjectRev2.Models;
using OOPProjectRev2.Services;

namespace OOPProjectRev2
{
    public partial class OrderInfo : Form
    {
        private readonly DataStore _datastore;
        private readonly Cart _currentCart;
        public OrderInfo()
        {
            InitializeComponent();
            _datastore = new DataStore();
            _datastore.LoadCart();
            _currentCart = _datastore.LoadCart();
        }
        private void AddOrderLinesToListView()
        {
            listViewItems.Items.Clear();
            foreach (var orderLine in _datastore.LoadOrderLines())
            {
                ListViewItem listViewItem = new ListViewItem(orderLine.Item.Name);
                listViewItem.SubItems.Add(orderLine.Quantity.ToString());
                listViewItem.SubItems.Add(orderLine.LineTotal.ToString("C"));
                listViewItem.SubItems.Add(orderLine.TaxAmt.ToString("C"));
                listViewItem.SubItems.Add(orderLine.Total.ToString("C"));
                listViewItems.Items.Add(listViewItem);
            }
        }
        private void UpdateCartDisplay()
        {
            AddOrderLinesToListView();
            labelSubtotal.Text = $"Subtotal: {_datastore.LoadCart().GetSubtotal():C}";
            labelTaxAmt.Text = $"Tax: {_datastore.LoadCart().GetTax():C}";
            labelTotal.Text = $"Total: {_datastore.LoadCart().GetTotal():C}";
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for placing an order! You may pick it up at the time selected.");
            this.Close();
        }

        private void OrderInfo_Load(object sender, EventArgs e)
        {
            UpdateCartDisplay();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to add.");
                return;
            }
            
            else
            {
                var selectedItem = listViewItems.SelectedItems[0].Text;
                var menuItem = _datastore.LoadRegularMenuItems().FirstOrDefault(item => item.Name == selectedItem);
                _currentCart.AddItem(menuItem, 1);
                _datastore.SaveCart(_currentCart);
                UpdateCartDisplay();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to add.");
                return;
            }
            else
            {
                var selectedItem = listViewItems.SelectedItems[0].Text;
                var menuItem = _datastore.LoadRegularMenuItems().FirstOrDefault(item => item.Name == selectedItem);
                _currentCart.RemoveItem(menuItem, 1);
                _datastore.SaveCart(_currentCart);
                UpdateCartDisplay();
            }
        }
    }
}
