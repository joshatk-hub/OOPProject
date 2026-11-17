using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Models
{
    internal class OrderConfirmation
    {
        public string ConfirmationCode { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime PickupDate { get; set; }
        public List<OrderConfirmationLine> Items { get; set; } = new List<OrderConfirmationLine>();
        public string Notes { get; set; } = string.Empty;
        public string Status { get; set; } = "Received"; //default status
        public decimal SubtotalPrice { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalPrice { get; set; }
    }

    internal class OrderConfirmationLine
    {
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal LineTotal { get; set; }
    }
}
