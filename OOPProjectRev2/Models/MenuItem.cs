using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Models
{
    public class MenuItem
    {
        public string Kind { get; set; } // "regular" or "seasonal"
        public string ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}
