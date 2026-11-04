using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Models
{
    public class MenuItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public DateTime SeasonStart { get; set; }
        public DateTime SeasonEnd { get; set; }
        public virtual bool InSeason(DateTime currentDate)
        {
            if (SeasonStart <= SeasonEnd)
            {
                return currentDate.Date >= SeasonStart.Date && currentDate.Date <= SeasonEnd.Date;
            }
            else
            {
                return currentDate.Date >= SeasonStart.Date || currentDate.Date <= SeasonEnd.Date;
            }
        }
    }
}
