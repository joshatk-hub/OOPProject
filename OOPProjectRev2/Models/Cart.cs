using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Models
{
    internal class Cart
    {
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
    }
}
