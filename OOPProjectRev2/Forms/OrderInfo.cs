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
        private readonly IDataRepository _datastore;
        private readonly Cart _currentCart;
        private readonly OrderConfirmationService _orderConfirmationService;
        private string _currentUserEmail = string.Empty;

        public OrderInfo()
        {
            InitializeComponent();
            _datastore = new DataStore();
            _currentCart = _datastore.LoadCart();
            _orderConfirmationService = new OrderConfirmationService(_datastore);
        }

        public void SetLoggedInUser(string email)
        {
            _currentUserEmail = email;
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
            // Optimized to read from the already loaded _currentCart variable
            labelSubtotal.Text = $"Subtotal: {_currentCart.GetSubtotal():C}";
            labelTaxAmt.Text = $"Tax: {_currentCart.GetTax():C}";
            labelTotal.Text = $"Total: {_currentCart.GetTotal():C}";
            labelPickup.Text = PickupDate();
        }
        private string PickupDate()
        {
            foreach (var orderLine in _currentCart.OrderLines)
            {
                DateTime minimumAllowedDateTime = DateTime.Now.AddHours(orderLine.Item.LeadTime);
                string labelPickup = $"The earliest you can pick up your order is {minimumAllowedDateTime:g}.";
                return labelPickup;
            }
            return "No valid pickup date available.";
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (_currentCart.OrderLines.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items to your cart before placing an order.");
                return;
            }
            if (dateTimePicker.Value < DateTime.Now)
            {
                MessageBox.Show("Please select a valid date and time for your order.");
                return;
            }
            foreach (var orderLine in _currentCart.OrderLines)
            {
                DateTime minimumAllowedDateTime = DateTime.Now.AddHours(orderLine.Item.LeadTime);

                if (dateTimePicker.Value < minimumAllowedDateTime)
                {
                    MessageBox.Show($"The item '{orderLine.Item.Name}' requires a lead time of {orderLine.Item.LeadTime} hours. The earliest you can place this order is {minimumAllowedDateTime:g}.");
                    return;
                }
            }
            // Create order confirmation
            string notes = textBoxNotes.Text;
            var confirmation = _orderConfirmationService.CreateOrderConfirmation(
                _currentCart,
                dateTimePicker.Value,
                notes
            );
            if (confirmation == null)
            {
                MessageBox.Show("Failed to create order confirmation.");
                return;
            }
            // check login
            if (!string.IsNullOrEmpty(_currentUserEmail))
            {
                // if logged in, save to account
                bool saved = _orderConfirmationService.SaveOrderConfirmationToCustomer(_currentUserEmail, confirmation);

                if (saved)
                {
                    MessageBox.Show(
                        $"Order placed successfully!\n\n" +
                        $"Confirmation Code: {confirmation.ConfirmationCode}\n" +
                        $"Pickup Date: {confirmation.PickupDate:MM/dd/yyyy HH:mm}\n" +
                        $"Total: {confirmation.TotalPrice:C}\n\n" +
                        $"Your order has been saved to your account.",
                        "Order Confirmed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    _datastore.SaveCart(new Cart());
                    UpdateCartDisplay();
                }
                else
                {
                    MessageBox.Show("Failed to save order confirmation. Please try again.");
                }
            }
            else
            {
                // show confirmation for guest
                MessageBox.Show(
                    $"Order placed successfully!\n\n" +
                    $"Confirmation Code: {confirmation.ConfirmationCode}\n" +
                    $"Pickup Date: {confirmation.PickupDate:MM/dd/yyyy HH:mm}\n" +
                    $"Total: {confirmation.TotalPrice:C}\n\n" +
                    $"Please save your confirmation code.\n" +
                    $"This order is not tied to an account.",
                    "Guest Order Confirmed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                _datastore.SaveCart(new Cart());
                UpdateCartDisplay();
            }
        }
        private void OrderInfo_Load(object sender, EventArgs e)
        {
            textBoxNotes.Clear();
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
                MessageBox.Show("Please select an item to remove.");
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
        private void buttonClear_Click(object sender, EventArgs e)
        {
            listViewItems.Items.Clear();
            _currentCart.Clear();
            textBoxNotes.Clear();
            UpdateCartDisplay();
        }
    }
}