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
