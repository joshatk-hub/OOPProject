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
        private SavedOrderService _savedOrderService;
        private string _currentUserEmail = string.Empty;

        public CustomerOrdering()
        {
            InitializeComponent();
            _datastore = new DataStore();
            _savedOrderService = new SavedOrderService(_datastore);
        }

        private void LoadSavedOrdersForUser()
        {
            if (string.IsNullOrEmpty(_currentUserEmail))
            {
                listViewSavedOrders.Items.Clear();
                return;
            }

            var savedOrders = _savedOrderService.GetSavedOrders(_currentUserEmail);

            listViewSavedOrders.Items.Clear();
            foreach (var order in savedOrders)
            {
                ListViewItem item = new ListViewItem(order.OrderName);
                item.SubItems.Add(order.SavedDate.ToString("MM/dd/yyyy HH:mm"));
                item.SubItems.Add(order.Items.Count.ToString());
                item.Tag = order.SavedOrderId;
                listViewSavedOrders.Items.Add(item);
            }
        }
        public void SetLoggedInUser(string email)
        {
            _currentUserEmail = email;
            LoadSavedOrdersForUser();
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
            if (!string.IsNullOrEmpty(_currentUserEmail))
            {
                orderInfo.SetLoggedInUser(_currentUserEmail);
            }
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

        private void buttonDelSaved_Click(object sender, EventArgs e)
        {
            if (listViewSavedOrders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an order to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listViewSavedOrders.SelectedItems[0];
            string savedOrderId = selectedItem.Tag.ToString();

            if (MessageBox.Show("Are you sure you want to delete this order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            bool success = _savedOrderService.DeleteSavedOrder(_currentUserEmail, savedOrderId);

            if (success)
            {
                MessageBox.Show("Order deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSavedOrdersForUser();
            }
            else
            {
                MessageBox.Show("Failed to delete order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentUserEmail))
            {
                MessageBox.Show("You must be logged in to save orders.", "Not Logged In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cart = _datastore.LoadCart();

            if (cart.OrderLines.Count == 0)
            {
                MessageBox.Show("Cart is empty. Nothing to save.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string orderName = PromptForOrderName();
            if (string.IsNullOrWhiteSpace(orderName))
                return;

            bool success = _savedOrderService.SaveCartAsOrder(_currentUserEmail, cart, orderName);

            if (success)
            {
                LoadSavedOrdersForUser();
            }
            else
            {
                MessageBox.Show("Failed to save order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string PromptForOrderName() // creates a new form 
        {
            using (var form = new Form())
            {
                form.Text = "Save Order";
                form.Width = 300;
                form.Height = 150;
                form.StartPosition = FormStartPosition.CenterParent;

                var label = new Label { Left = 20, Top = 20, Text = "Order Name:", Width = 250 };
                var textBox = new TextBox { Left = 20, Top = 50, Width = 250 };
                var okButton = new Button { Text = "OK", Left = 120, Width = 80, Top = 80, DialogResult = DialogResult.OK };
                var cancelButton = new Button { Text = "Cancel", Left = 200, Width = 80, Top = 80, DialogResult = DialogResult.Cancel };

                form.Controls.Add(label);
                form.Controls.Add(textBox);
                form.Controls.Add(okButton);
                form.Controls.Add(cancelButton);
                form.AcceptButton = okButton;
                form.CancelButton = cancelButton;

                return form.ShowDialog() == DialogResult.OK ? textBox.Text : null;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentUserEmail))
            {
                MessageBox.Show("You must be logged in to load saved orders.", "Not Logged In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listViewSavedOrders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an order to load.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listViewSavedOrders.SelectedItems[0];
            string savedOrderId = selectedItem.Tag.ToString();
            string orderName = selectedItem.Text;

            // get all available menu items
            var availableItems = new List<MenuItem>();
            availableItems.AddRange(_datastore.LoadRegularMenuItems());
            availableItems.AddRange(_datastore.LoadSeasonalMenuItems());
            bool success = _savedOrderService.ApplySavedOrderToCart(_currentUserEmail, savedOrderId, availableItems, _datastore);
            if (!success)
            {
                MessageBox.Show("Failed to apply order. The saved order may be empty or items are unavailable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // get updated cart for display
            var updatedCart = _datastore.LoadCart();
            MessageBox.Show($"Successfully added '{orderName}' to cart!\n\nTotal items in cart: {updatedCart.OrderLines.Count}", "Order Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}