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
        public decimal LineTotal => Item.Price * Quantity;
    }
}
