using OOPProjectRev2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Models
{
    public class UserAccount
    {
        private readonly DataStore _dataStore = new DataStore();
        public List<UserAccount> Customers { get; set; } = new List<UserAccount>();
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool VerifyPassword(string inputPassword)
        {
            if (string.IsNullOrEmpty(Password))
            {
                return false;
            }

            return Password == inputPassword;
        }
    }
}
