using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Models
{
    internal class Order
    {
        public string ConfirmationNumber { get; set; } // dor identity confirmation at pickup
        public string CustomerEmail { get; set; }
        public List<OrderLine> Lines { get; set; } = new List<OrderLine>();
        public DateTime PickupTime { get; set; }
        public string Status { get; set; } = "Received"; // will have statuses Received, Baking, Ready, Picked Up, Cancelled
        public string SpecialNotes { get; set; } // for allergens or special instructions
    }
}
