using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plan_o_Tron_6000.Statics;

namespace Plan_o_Tron_6000.Domain
{
    public class WarehouseItem
    {
        public WarehouseItem(int amount , double price, Item item)
        {
            this.Price = price;
            this.Amount = amount;
            this.Item = item;
        }

        public Item Item { get; private set; }

        public int Amount { get; set; }

        public double Price
        {
            get;
            set;
        }

        public double StockValue
        {
            get
            {
                return this.Amount * this.Price;
            }
        }

    }
}
