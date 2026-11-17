using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPProjectRev2.Models;

namespace OOPProjectRev2.Services
{
    internal class SavedOrderService
    {
        private readonly IDataRepository _dataRepository;

        public SavedOrderService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public bool SaveCartAsOrder(string email, Cart cart, string orderName, string notes = "")
        {
            if (string.IsNullOrWhiteSpace(email) || cart == null || cart.OrderLines.Count == 0)
            {
                return false;
            }
            var currentData = _dataRepository.LoadCustomer();
            var customer = currentData.Customers.FirstOrDefault(c =>
                string.Equals(c.Email?.Trim(), email.Trim(), StringComparison.OrdinalIgnoreCase));
            if (customer == null)
            {
                return false;
            }
            var savedOrder = new SavedOrder
            {
                OrderName = orderName,
                Notes = notes,
                SavedDate = DateTime.Now,
                Items = cart.OrderLines.Select(ol => new SavedOrderLine
                {
                    ItemId = ol.Item.ID,
                    ItemName = ol.Item.Name,
                    Category = ol.Item.Category,
                    Quantity = ol.Quantity,
                    Price = ol.Item.Price
                }).ToList()
            };

            customer.SavedOrders.Add(savedOrder);
            _dataRepository.SaveCustomer(currentData);

            return true;
        }
        public List<SavedOrder> GetSavedOrders(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return new List<SavedOrder>();
            }

            var currentData = _dataRepository.LoadCustomer();
            var customer = currentData.Customers.FirstOrDefault(c =>
                string.Equals(c.Email?.Trim(), email.Trim(), StringComparison.OrdinalIgnoreCase));

            return customer?.SavedOrders ?? new List<SavedOrder>();
        }
        public SavedOrder GetSavedOrderById(string email, string savedOrderId)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(savedOrderId))
            {
                return null;
            }

            var savedOrders = GetSavedOrders(email);
            return savedOrders.FirstOrDefault(so => so.SavedOrderId == savedOrderId);
        }
        public bool DeleteSavedOrder(string email, string savedOrderId)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(savedOrderId))
            {
                return false;
            }
            var currentData = _dataRepository.LoadCustomer();
            var customer = currentData.Customers.FirstOrDefault(c =>
                string.Equals(c.Email?.Trim(), email.Trim(), StringComparison.OrdinalIgnoreCase));

            if (customer == null)
            {
                return false;
            }
            var savedOrder = customer.SavedOrders.FirstOrDefault(so => so.SavedOrderId == savedOrderId);
            if (savedOrder == null)
            {
                return false;
            }

            customer.SavedOrders.Remove(savedOrder);
            _dataRepository.SaveCustomer(currentData);

            return true;
        }
        public Cart LoadSavedOrderAsCart(string email, string savedOrderId, List<MenuItem> availableItems)
        {
            var savedOrder = GetSavedOrderById(email, savedOrderId);
            if (savedOrder == null)
            {
                return new Cart();
            }

            var cart = new Cart();
            foreach (var line in savedOrder.Items)
            {
                var menuItem = availableItems.FirstOrDefault(mi => mi.ID == line.ItemId);
                if (menuItem != null)
                {
                    cart.AddItem(menuItem, line.Quantity);
                }
            }

            return cart;
        }
        public bool ApplySavedOrderToCart(string email, string savedOrderId, List<MenuItem> availableItems, IDataRepository dataRepository)
        {
            var savedOrder = GetSavedOrderById(email, savedOrderId);
            if (savedOrder == null || savedOrder.Items.Count == 0)
            {
                return false;
            }
            var currentCart = dataRepository.LoadCart();
            foreach (var savedOrderLine in savedOrder.Items)
            {
                var menuItem = availableItems.FirstOrDefault(mi => mi.ID == savedOrderLine.ItemId);
                if (menuItem != null)
                {
                    currentCart.AddItem(menuItem, savedOrderLine.Quantity);
                }
            }
            dataRepository.SaveCart(currentCart);
            return true;
        }
    }
}
