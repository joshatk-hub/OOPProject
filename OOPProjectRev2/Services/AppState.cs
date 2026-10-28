using OOPProjectRev2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Services
{
    internal class AppState
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public List<CustomerAccount> Customers { get; set; } = new List<CustomerAccount>();
        public List<Order> SavedOrders { get; set; } = new List<Order>();
    }
}
