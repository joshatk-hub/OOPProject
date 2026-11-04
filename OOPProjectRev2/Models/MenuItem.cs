using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Models
{
    public abstract class MenuItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public virtual bool InSeason (DateTime currentDate)
        {
            return true; // for normal items
        }

    }
}
