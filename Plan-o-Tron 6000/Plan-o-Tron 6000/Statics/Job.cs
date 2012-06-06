using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plan_o_Tron_6000.Statics
{
    /// <summary>
    /// Definiert einen Arbeitsablauf der ein Arbeitsplatz durchführt
    /// </summary>
    public class Job
    {
        public Job(JobId id, Workstation station, List<Part> material, int setUp, int time)
        {
            this.id = id;
            this.Station = station;
            this.Material = material;
            this.SetUpTime = setUp;
            this.ProductionTime = time;
        }

        public Job(JobId id, Workstation station, List<Part> material, int setUp, int time, Item good)
            : this(id, station, material, setUp, time)
        {
            this.CreatedItem = good;
        }

        public Job(JobId id, Workstation station, List<Part> material, int setUp, int time, JobId followUp)
            : this(id, station, material, setUp, time)
        {
            this.CreatedItem = null;
            this.FollowUp = followUp;
        }

        public JobId id { get; private set; }

        public Workstation Station { get; private set; }

        // Material das gebraucht wird
        public List<Part> Material { get; protected set; }

        //Rüstzeit in Minuten
        public int SetUpTime { get; private set; }

        //Arbeitszeit je Werkstück in Minuten
        public int ProductionTime { get; private set; }

        //2 Möglichkeiten: folgender Arbeitsschritt oder erzeugtes Zwischenprodukt werden angegeben

        //Produzierte Ware, wenn keine null setzen
        public Item CreatedItem { get; private set; }

        //Nachfolgender Arbeitsschritt
        public JobId FollowUp { get; private set; }

        //Zwischenprodukt erzeugt?
        public bool ProduceGood
        {
            get
            {
                return CreatedItem != null;
            }
        }
    }
}
