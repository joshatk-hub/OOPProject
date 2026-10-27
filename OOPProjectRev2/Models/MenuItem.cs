using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Models
{
    internal class MenuItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public bool InSeason { get; set; } // whether the item is in season or not

        public DateTime SeasonStart { get; set; }
        public DateTime SeasonEnd { get; set; } 

    }
}
