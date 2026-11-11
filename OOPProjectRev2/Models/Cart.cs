using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using OOPProjectRev2.Models;
using OOPProjectRev2.Services;


namespace OOPProjectRev2.Models
{
    internal class Cart
    {
        private readonly DataStore _dataStore = new DataStore();
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
        public void AddItem(MenuItem item, int quantity)
        {
            if (item == null || quantity <= 0) return;
            var existingLine = OrderLines.FirstOrDefault(l => l.Item.ID == item.ID);
            if (existingLine != null)
            {
                existingLine.Quantity += quantity;
                
            }
            else
            {
                OrderLines.Add(new OrderLine { Item = item, Quantity = quantity });
            }
        }
        public void UpdateQuantity(string itemId, int quantity)
        {
            var line = OrderLines.FirstOrDefault(l => l.Item.ID == itemId);
            if (line == null)
                return;
            {
                if (quantity <= 0)
                {
                    OrderLines.Remove(line);
                }
                else
                {
                    line.Quantity = quantity;
                }
            }
        }
        public void RemoveItem(MenuItem item, int quantity = 1)
        {
            if (item == null || quantity <= 0) return;
            var existingLine = OrderLines.FirstOrDefault(l => l.Item.ID == item.ID);
            if (existingLine != null)
            {
                existingLine.Quantity -= quantity;
                if (existingLine.Quantity <= 0)
                {
                    OrderLines.Remove(existingLine);
                }
            }
            else
            {
                OrderLines.Add(new OrderLine { Item = item, Quantity = quantity });
            }
        }

        public void Clear()
        {
            _dataStore.SaveCart(new Cart()); // ave an empty cart to the datastore
            OrderLines.Clear();
        }
        public decimal GetSubtotal()
        {
            return OrderLines.Sum(l => l.LineTotal);
        }   
        public decimal GetTax()
        {
            return OrderLines.Sum(l => l.TaxAmt);
        }
        public decimal GetTotal()
        {
            return OrderLines.Sum(l => l.Total);
        }

        public int GetTotalItemCount()
        {
            return OrderLines.Sum(l => l.Quantity);
        }
    }
}
