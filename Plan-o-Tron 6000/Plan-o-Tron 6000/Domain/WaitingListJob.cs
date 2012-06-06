using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plan_o_Tron_6000.Statics;

namespace Plan_o_Tron_6000.Domain
{
    public class WaitingListJob
    {
        public List<WaitingListItem> Items { get; set; }

        public double TimeNeeded 
        { 
            
            get 
            {
                double res = 0;
                foreach (WaitingListItem it in Items)
                {
                    res += it.TimeNeeded;
                }
                return res;
            }
        }

        public Item WaitingItem { get; set; }

        public int Amount { get; set; }

    }
}
