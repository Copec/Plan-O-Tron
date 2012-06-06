using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plan_o_Tron_6000.Domain
{
    public class WaitingLists
    {

        public WaitingLists()
        {
            this.Jobs = null;
        }

        public WaitingLists(List<WaitingListJob> jobs)
        {
            this.Jobs = jobs;
        }

        public List<WaitingListJob> Jobs { get; set; }

        public List<WaitingListItem> WaitingListStock { get; set; }

        public List<WaitingListJob> OrdersInWork { get; set; }

    }
}
