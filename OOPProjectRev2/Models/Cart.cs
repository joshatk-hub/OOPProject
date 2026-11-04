using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace OOPProjectRev2.Models
{
    internal class Cart
    {
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
        public void AddItem(MenuItem item, int quantity = 1)
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
        public void RemoveItem(string itemId)
        {
            OrderLines.RemoveAll(l => l.Item.ID == itemId);
        }

        public void Clear()
        {
            OrderLines.Clear();
        }

        public decimal GetSubtotal()
        {
            return OrderLines.Sum(l => l.LineTotal);
        }

        public int GetTotalItemCount()
        {
            return OrderLines.Sum(l => l.Quantity);
        }
    }
}
