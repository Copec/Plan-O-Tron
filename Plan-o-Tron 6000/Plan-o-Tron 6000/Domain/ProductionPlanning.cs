using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plan_o_Tron_6000.Domain
{

    public class ProductionPlanning
    {
        //TODO: Periode aus xml beziehen
        private int currPeriod = 2;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amounts">Liste von einzelnen Perioden in Arrays für alle 3 Produkte</param>
        public ProductionPlanning(List<int[]> amounts)
        {
            this.Periods = new List<ProductionPeriod>();
            this.Periods.Add(new ProductionPeriod(currPeriod, amounts[0]));
            this.Periods.Add(new ProductionPeriod(currPeriod + 1, amounts[1]));
            this.Periods.Add(new ProductionPeriod(currPeriod + 2, amounts[2]));
            this.Periods.Add(new ProductionPeriod(currPeriod + 3, amounts[3]));
        }

        public List<ProductionPeriod> Periods {get; private set;}

        public class ProductionPeriod
        {
            public ProductionPeriod (int period, int[] amounts)
	        {
                this.Period = period;
                this.Product1 = amounts[0];
                this.Product2 = amounts[1];
                this.Product3 = amounts[2];
	        }

            public int Period {get; set;}

            public int Product1 {get; private set;}
            public int Product2 {get; private set;}
            public int Product3 {get; private set;}
        }

    }
}
