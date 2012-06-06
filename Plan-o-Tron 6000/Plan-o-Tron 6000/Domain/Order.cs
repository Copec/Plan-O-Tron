using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plan_o_Tron_6000.Statics;

namespace Plan_o_Tron_6000.Domain
{
    public class Order
    {
        //Future
        public Order(bool express, int orderPeriod, Item item, int amount)
        {
            this.ExpressOrder = express;
            this.OrderPeriod = orderPeriod;
            this.WarehouseItem = new WarehouseItem(amount, -1, item);
            this.Ordercosts = -1;
            this.TimeOfArrival = -1;
        }

        public bool ExpressOrder { get; private set; }

        public int OrderPeriod { get; private set; }

        public int TimeOfArrival { get; private set; }

        //Was und wieviel wurde zu welchem Preis bestellt?
        public WarehouseItem WarehouseItem { get; private set; }

        //Bestellkosten
        public double Ordercosts { get; private set; }

        //Gesamte Kosten
        public double TotalCosts
        {
            get
            {
                return this.Ordercosts + this.WarehouseItem.StockValue;
            }
        }

        public double CostsPerPiece
        {
            get
            {
                return this.TotalCosts / this.WarehouseItem.Amount;
            }
        }


    }
}
