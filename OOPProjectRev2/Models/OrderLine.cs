using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Models
{
    internal class OrderLine
    {
        private decimal _lineTotal;
        public MenuItem Item { get; set; }
        public int Quantity { get; set; }
        public decimal LineTotal { 
            get { return _lineTotal; } 
            set 
            {
                if (Item.Name == "Cookies" || Item.Name == "Muffins")
                {
                    if (Quantity % 13 == 0)
                    {
                        _lineTotal = (Quantity * Item.Price) - (Item.Price); // apply bakers dozen rule discount if quantity is a multiple of 12
                    }
                    else
                    {
                        _lineTotal = Quantity * Item.Price;
                    }
                }
                else { _lineTotal = Quantity * Item.Price; }
            }
        }
        public static decimal TaxRate = .08m;
        public decimal TaxAmt => (LineTotal * TaxRate);
        public decimal Total => LineTotal + TaxAmt;
    }
}
