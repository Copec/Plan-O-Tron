using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plan_o_Tron_6000.Domain
{
    public class Orders
    {
        public Orders()
        {
            this.Future = new List<Order>();
        }

        //public List<Order> Incoming;
        public List<Order> Future;

    }
}
