using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plan_o_Tron_6000.Statics
{
    public class Part
    {

        public Part(int amount, Item it)
        {
            this.PartItem = it;
            this.Amount = amount;
        }

        public int Amount { get; set; }

        public Item PartItem { get; set; }

        public override string ToString()
        {
            return this.Amount.ToString() + " * " + this.PartItem.ToString();
        }
    }
}
