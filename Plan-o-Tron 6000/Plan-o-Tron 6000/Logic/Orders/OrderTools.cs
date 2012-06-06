using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plan_o_Tron_6000.Logic.Orders
{
    public static class OrderTools
    {
        public static int OptValue = 200;
        public static double Stockcosts = 0.6;
        public static int StockmovementDay = 1;

        /// <summary>
        /// Optimale Bestellmenge
        /// </summary>
        /// <param name="toProduce">Durschnittlicher verbrauch der Teile </param>
        /// <param name="orderCosts">Bestellkosten</param>
        /// <param name="partCosts">Teilepreis</param>
        /// <param name="PeriodCount">Anzahl Perioden in toProduce</param>
        /// <returns>Optimale Bestellmenge</returns>
        public static double OptimalOrder(int toProduce, double orderCosts, double partCosts, int periodCount)
        {
            // =WURZEL((200*(toProduce/4)*orderCosts)/(partCosts*0,6))
            return Math.Sqrt(OrderTools.OptValue * (toProduce / periodCount) * orderCosts) / (partCosts * OrderTools.Stockcosts);
        }

        /// <summary>
        /// optimaler Bestellpunkt
        /// </summary>
        /// <param name="supplyPerDay">durchschnittlicher verbrauch des teil PRO TAG</param>
        /// <param name="ordertime">Lieferfrist in Tagen</param>
        /// <param name="security">Tage die der Sicherheitsbestand reicht</param>
        /// <returns>optimaler Bestellpunkt</returns>
        public static int MomentofOrder(double supplyPerDay, int ordertime, int security)
        {
            // ([durchschnittlicher] verbrauch des teil PRO TAG * (Lieferfrist in Tagen + 1 Tag + Tage die der Sicherheitsbestand reicht)
            return  (int) (Math.Round((supplyPerDay * (ordertime + OrderTools.StockmovementDay + security))));
        }

        /// <summary>
        /// Sicherheitsbestand
        /// </summary>
        /// <param name="diff">Lieferabweichung in Tagen</param>
        /// <param name="supplyPerDay">durchschnittlicher verbrauch des Teils pro tag</param>
        /// <returns>Sicherheitsbestand</returns>
        public static int SecurityStock(double diff, double supplyPerDay)
        {
            // Lieferabweichung in Tagen * durchschnittlicher verbrauch des Teils pro tag
            return (int)(Math.Round((supplyPerDay * diff)));
        }

    }
}
