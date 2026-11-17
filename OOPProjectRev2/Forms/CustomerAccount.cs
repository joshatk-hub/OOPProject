using OOPProjectRev2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPProjectRev2.Services;

namespace OOPProjectRev2
{
    public partial class CustomerAccount : Form
    {
        private readonly IDataRepository _dataRepository;
        private readonly AccountService _accountService;
        private readonly OrderConfirmationService _orderConfirmationService;
        private string _currentUserEmail = string.Empty;
        internal OOPProjectRev2.Models.UserAccount LoggedInCustomer { get; private set; }
        public CustomerAccount()
        {
            InitializeComponent();
            _dataRepository = new DataStore();
            _accountService = new AccountService(_dataRepository);
            _orderConfirmationService = new OrderConfirmationService(_dataRepository);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_accountService.Authenticate(email, password))
            {
                LoggedInCustomer = _accountService.GetCustomerByEmail(email);
                _currentUserEmail = email;
                MessageBox.Show($"Welcome back, {LoggedInCustomer.Username}!", "Sign In Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Load and display orders
                LoadOrdersForUser(email);

                // Pass email to CustomerOrdering
                if (Application.OpenForms["CustomerOrdering"] is CustomerOrdering orderForm)
                {
                    orderForm.SetLoggedInUser(email);
                }

                // Pass email to OrderInfo if it's open
                if (Application.OpenForms["OrderInfo"] is OrderInfo infoForm)
                {
                    infoForm.SetLoggedInUser(email);
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please check your credentials.", "Sign In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrdersForUser(string email)
        {
            var orders = _orderConfirmationService.GetOrderConfirmationsByEmail(email);
            listViewOrders.Items.Clear();

            foreach (var order in orders)
            {
                ListViewItem item = new ListViewItem(order.ConfirmationCode);
                item.SubItems.Add(order.PickupDate.ToString("MM/dd/yyyy HH:mm"));
                item.SubItems.Add(order.Status);
                item.Tag = order.ConfirmationCode;
                listViewOrders.Items.Add(item);
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string phone = textBoxNumber.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all fields (Phone, Email, and Password).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = email.Split('@')[0];

            bool success = _accountService.CreateAccount(email, username, phone, password);

            if (success)
            {
                MessageBox.Show("Account created successfully! You can now sign in.", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the fields
                textBoxEmail.Clear();
                textBoxPassword.Clear();
                textBoxNumber.Clear();
            }
            else
            {
                MessageBox.Show("Failed to create account. The email may already exist.", "Account Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
