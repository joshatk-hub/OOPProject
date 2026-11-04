using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Models
{
    internal class SeasonalItem : MenuItem
    {
        public DateTime SeasonStart { get; set; }
        public DateTime SeasonEnd { get; set; }
        public override bool InSeason(DateTime currentDate)
        {
            if (SeasonStart <= SeasonEnd)
            {
                return currentDate.Date >= SeasonStart.Date && currentDate.Date <= SeasonEnd.Date;
            }
            else
            {
                return currentDate.Date >= SeasonStart.Date || currentDate.Date <= SeasonEnd.Date; // to handle winter related items, which go into the next calendar year
            }
        }
    }
}
