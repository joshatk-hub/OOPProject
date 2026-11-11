using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using OOPProjectRev2.Services;
using OOPProjectRev2.Models;

namespace OOPProjectRev2.Services
{
    internal class AccountService
    {
        private readonly IDataRepository _dataRepository;
        public AccountService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public List<UserAccount> GetAllCustomerAccounts()
        {
            var state = _dataRepository.LoadCustomer();
            return state.Customers ?? new List<UserAccount>();
        }
        public UserAccount GetCustomerByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return null;

            var customers = GetAllCustomerAccounts();
            return customers.FirstOrDefault(c =>
                string.Equals(c.Email?.Trim(), email.Trim(), StringComparison.OrdinalIgnoreCase));
        }
        public bool Authenticate(string email, string password)
        {
            var customer = GetCustomerByEmail(email);
            if (customer == null)
            {
                return false;
            }
            return customer.VerifyPassword(password);
        }
    }
}
