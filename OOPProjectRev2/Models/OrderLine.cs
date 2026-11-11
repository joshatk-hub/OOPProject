using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Models
{
    internal class OrderLine
    {
        public MenuItem Item { get; set; }
        public int Quantity { get; set; }
        public decimal LineTotal { 
            get
            {
                if (Item.Category == "Cookies" || Item.Category == "Muffins")
                {
                    int freeItems = Quantity / 13;
                    return (Quantity - freeItems) * Item.Price;
                }
                else 
                { 
                    return Quantity * Item.Price; 
                }
            }
        }
        public static decimal TaxRate = .08m;
        public decimal TaxAmt => (LineTotal * TaxRate);
        public decimal Total => LineTotal + TaxAmt;
        public string Notes { get; set; } = string.Empty;
    }
}
