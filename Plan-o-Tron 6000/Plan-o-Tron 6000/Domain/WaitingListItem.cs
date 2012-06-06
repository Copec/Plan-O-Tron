using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plan_o_Tron_6000.Statics;

namespace Plan_o_Tron_6000.Domain
{
    public class WaitingListItem
    {
        public WaitingListItem(double time, Item waitingItem, int amount)
        {
            this.TimeNeeded = time;
            this.WaitingItem = waitingItem;
            this.Amount = amount;
        }

        public WaitingListItem(Item waitingItem, int amount)
        {
            this.TimeNeeded = -1;
            this.WaitingItem = waitingItem;
            this.Amount = amount;
        }

        public double TimeNeeded { get; private set; }

        public Item WaitingItem { get; set; }

        public int Amount { get; set; }

    }
}
