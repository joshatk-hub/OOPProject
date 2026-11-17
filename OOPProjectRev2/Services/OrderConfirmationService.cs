using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPProjectRev2.Models;

namespace OOPProjectRev2.Services
{
    internal class OrderConfirmationService
    {
        private readonly IDataRepository _dataRepository;

        public OrderConfirmationService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public string GenerateConfirmationCode()
        {
            string dateString = DateTime.Now.ToString("yyMMdd");
            string randomNumber = new Random().Next(0, 1000).ToString("D3");
            return $"OBB-{dateString}-{randomNumber}";
        }
        public OrderConfirmation CreateOrderConfirmation(
            Cart cart,
            DateTime pickupDate,
            string notes = "")
        {
            if (cart == null || cart.OrderLines.Count == 0)
            {
                return null;
            }
            var confirmation = new OrderConfirmation
            {
                ConfirmationCode = GenerateConfirmationCode(),
                OrderDate = DateTime.Now,
                PickupDate = pickupDate,
                Items = cart.OrderLines.Select(ol => new OrderConfirmationLine
                {
                    ItemId = ol.Item.ID,
                    ItemName = ol.Item.Name,
                    Category = ol.Item.Category,
                    Quantity = ol.Quantity,
                    Price = ol.Item.Price,
                    LineTotal = ol.LineTotal
                }).ToList(),
                Notes = notes,
                Status = "Received",
                SubtotalPrice = cart.GetSubtotal(),
                TaxAmount = cart.GetTax(),
                TotalPrice = cart.GetTotal()
            };

            return confirmation;
        }
        public bool SaveOrderConfirmationToCustomer(string email, OrderConfirmation confirmation)
        {
            if (confirmation == null || string.IsNullOrEmpty(email))
            {
                return false;
            }

            try
            {
                var currentData = _dataRepository.LoadCustomer();
                var customer = currentData.Customers.FirstOrDefault(c =>
                    string.Equals(c.Email?.Trim(), email.Trim(), StringComparison.OrdinalIgnoreCase));

                if (customer == null)
                {
                    return false;
                }

                customer.OrderConfirmations.Add(confirmation);
                _dataRepository.SaveCustomer(currentData);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<OrderConfirmation> GetOrderConfirmationsByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return new List<OrderConfirmation>();
            }

            var currentData = _dataRepository.LoadCustomer();
            var customer = currentData.Customers.FirstOrDefault(c =>
                string.Equals(c.Email?.Trim(), email.Trim(), StringComparison.OrdinalIgnoreCase));

            return customer?.OrderConfirmations ?? new List<OrderConfirmation>();
        }
        public OrderConfirmation GetOrderConfirmationByCode(string email, string confirmationCode)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(confirmationCode))
            {
                return null;
            }

            var confirmations = GetOrderConfirmationsByEmail(email);
            return confirmations.FirstOrDefault(oc => oc.ConfirmationCode == confirmationCode);
        }
        public bool UpdateOrderStatus(string email, string confirmationCode, string newStatus)
        {
            var currentData = _dataRepository.LoadCustomer();
            var customer = currentData.Customers.FirstOrDefault(c =>
                string.Equals(c.Email?.Trim(), email.Trim(), StringComparison.OrdinalIgnoreCase));

            if (customer == null)
            {
                return false;
            }

            var confirmation = customer.OrderConfirmations.FirstOrDefault(oc => oc.ConfirmationCode == confirmationCode);

            if (confirmation == null)
            {
                return false;
            }

            confirmation.Status = newStatus;
            _dataRepository.SaveCustomer(currentData);
            return true;
        }
    }
}
