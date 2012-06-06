using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plan_o_Tron_6000.Statics;

namespace Plan_o_Tron_6000.Domain
{
    /// <summary>
    /// Warenlager
    /// </summary>
    public class Warehouse
    {
        public List<WarehouseItem> Stock;

        public Warehouse()
        {
            Stock = new List<WarehouseItem>();
        }

        public void SetAmount(ItemId id, int amount)
        {
            Stock.Single(e => e.Item.Id.Equals(id)).Amount = amount;
        }

        public int GetAmount(ItemId id)
        {
            return Stock.Single(e => e.Item.Id.Equals(id)).Amount;
        }

        public double GetPrice(ItemId id)
        {
            return Stock.Single(e => e.Item.Id.Equals(id)).Price;
        }

        public double GetStockvalue(ItemId id)
        {
            return Stock.Single(e => e.Item.Id.Equals(id)).StockValue;
        }

        public double TotalStockValue
        {
            get
            {
                double result = 0;

                foreach (var entry in this.Stock)
                {
                    result += entry.StockValue;
                }

                return result;
            }
        }
    }
}
