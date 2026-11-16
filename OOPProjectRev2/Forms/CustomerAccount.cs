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

namespace OOPProjectRev2
{
    public partial class CustomerAccount : Form
    {
        private readonly IDataRepository _dataRepository;
        private readonly AccountService _accountService;
        public OOPProjectRev2.Models.UserAccount LoggedInCustomer { get; private set; }
        public CustomerAccount()
        {
            InitializeComponent();
            _dataRepository = new DataStore();
            _accountService = new AccountService(_dataRepository);
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

                MessageBox.Show($"Welcome back, {LoggedInCustomer.Username}!", "Sign In Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please check your credentials.", "Sign In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
