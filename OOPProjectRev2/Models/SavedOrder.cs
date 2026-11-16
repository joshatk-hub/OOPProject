using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Models
{
    public class SavedOrder
    {
        public string SavedOrderId { get; set; } = Guid.NewGuid().ToString();
        public string OrderName { get; set; } = string.Empty;
        public List<SavedOrderLine> Items { get; set; } = new List<SavedOrderLine>();
        public decimal TotalPrice => Items.Sum(item => item.Price * item.Quantity);
        public DateTime SavedDate { get; set; } = DateTime.Now;
        public string Notes { get; set; } = string.Empty;
    }

    public class SavedOrderLine
    {
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
            