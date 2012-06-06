using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plan_o_Tron_6000.Statics
{
    /// <summary>
    /// Musterklasse für Arbeitsplätze. Analog zu Items.cs
    /// </summary>
    public class Workstation
    {
        //Löhne überall gleich können also ausserhalb gespeichert werden


        public Workstation(StationId id, double varCosts, double fixCosts)
        {
            this.Id = id;
            this.Jobs = null;
        }

        public Workstation(StationId id, List<Job> jobs, double varCosts, double fixCosts)
        {
            this.Id = id;
            this.Jobs = jobs;
        }


        public Workstation(StationId id, Job job, double varCosts, double fixCosts)
            : this(id, new List<Job>(){job}, varCosts, fixCosts)
        {

        }

        public StationId Id { get; protected set; }

        //Variable MaschinenKosten
        public double varCosts { get; private set; }

        //Fixe MaschinenKosten vgl. folie 19
        public double fixCosts { get; private set; }

        public List<Job> Jobs { get; set; }

        public override string ToString()
        {
            return "Arbeitsplatz " + (int)(this.Id) + ": " + this.Id;
        }
    }
}
