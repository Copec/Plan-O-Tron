using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plan_o_Tron_6000.Statics
{
    /// <summary>
    /// Zum einfacheren Ansprechen wird die Liste geschachtelt
    /// </summary>
    public class JobList
    {
        public JobList()
        {
            this.JobsByStation = new Dictionary<Workstation, List<Job>>();

            //TODO: Füllen

            //erste Station
            var station = new Workstation(StationId.Eins, .05, .01);
            var jobs = new List<Job>();
 
            //Kinder
            List<Part> parts = new List<Part>();
            parts.Add((new Part(1, Program.List.SchutzblechVorneK)));
            parts.Add((new Part(1, Program.List.VorderradgruppeK)));
            parts.Add((new Part(1, Program.List.RahmenK)));
            parts.Add((new Part(2, Program.List.Mutter34)));
            parts.Add((new Part(2, Program.List.Scheibe38)));
            
            var job = new Job(JobId.VorderradMontageK, station, parts, 20, 6, Program.List.VorderradgruppeK);
            jobs.Add(job);

            //Damen
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.SchutzblechVorneD)));
            parts.Add((new Part(1, Program.List.RahmenD)));
            parts.Add((new Part(1, Program.List.VorderradgruppeD)));
            parts.Add((new Part(2, Program.List.Mutter34)));
            parts.Add((new Part(2, Program.List.Scheibe38)));
            
            job = new Job(JobId.VorderradMontageD, station, parts, 20, 6, Program.List.VorderradgruppeD);
            jobs.Add(job);

            //Herren
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.SchutzblechVorneH)));
            parts.Add((new Part(1, Program.List.RahmenH)));
            parts.Add((new Part(1, Program.List.VorderradgruppeH)));
            parts.Add((new Part(2, Program.List.Mutter34)));
            parts.Add((new Part(2, Program.List.Scheibe38)));
            
            job = new Job(JobId.VorderradMontageH, station, parts, 20, 6, Program.List.VorderradgruppeH);
            jobs.Add(job);
            
            this.JobsByStation.Add(station, jobs);

            
            
            //Zweite Station

            station = new Workstation(StationId.Zwei, .05, .01);
            jobs = new List<Job>();
            
            //Kinder
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.VorderradMontK)));
            parts.Add((new Part(1, Program.List.HinterradgruppeK)));
            parts.Add((new Part(1, Program.List.SchutzblechHintenK)));
            parts.Add((new Part(2, Program.List.Mutter38)));
            parts.Add((new Part(2, Program.List.Scheibe38)));
            
            job = new Job(JobId.RahmenUndRaederK, station, parts, 30, 5, Program.List.RahmenUndRaederK);
            jobs.Add(job);

            //Damen
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.VorderradMontD)));
            parts.Add((new Part(1, Program.List.HinterradgruppeD)));
            parts.Add((new Part(1, Program.List.SchutzblechHintenD)));
            parts.Add((new Part(2, Program.List.Mutter38)));
            parts.Add((new Part(2, Program.List.Scheibe38)));
            
            job = new Job(JobId.RahmenUndRaederD, station, parts, 30, 5, Program.List.RahmenUndRaederD);
            jobs.Add(job);

            //Herren
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.VorderradMontH)));
            parts.Add((new Part(1, Program.List.HinterradgruppeH)));
            parts.Add((new Part(1, Program.List.SchutzblechHintenH)));
            parts.Add((new Part(2, Program.List.Mutter38)));
            parts.Add((new Part(2, Program.List.Scheibe38)));
            
            job = new Job(JobId.RahmenUndRaederH, station, parts, 20, 5, Program.List.RahmenUndRaederH);
            jobs.Add(job);
            
            this.JobsByStation.Add(station, jobs);
            
            
            
            //Dritte Station
            
            station = new Workstation(StationId.Drei, .05, .01);
            jobs = new List<Job>();
            
            //Kinder
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.SattelCpl)));
            parts.Add((new Part(1, Program.List.LenkerCpl)));
            parts.Add((new Part(1, Program.List.RahmenUndRaederK)));
            parts.Add((new Part(1, Program.List.Mutter38)));
            parts.Add((new Part(1, Program.List.Schraube38)));
            
            job = new Job(JobId.FahrradOhnePedaleK, station, parts, 20, 5, Program.List.FahrradOhnePedaleK);
            jobs.Add(job);

            //Damen
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.SattelCpl)));
            parts.Add((new Part(1, Program.List.LenkerCpl)));
            parts.Add((new Part(1, Program.List.RahmenUndRaederD)));
            parts.Add((new Part(1, Program.List.Mutter38)));
            parts.Add((new Part(1, Program.List.Schraube38)));
            
            job = new Job(JobId.FahrradOhnePedaleD, station, parts, 20, 6, Program.List.FahrradOhnePedaleD);
            jobs.Add(job);

            //Herren
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.SattelCpl)));
            parts.Add((new Part(1, Program.List.LenkerCpl)));
            parts.Add((new Part(1, Program.List.RahmenUndRaederH)));
            parts.Add((new Part(1, Program.List.Mutter38)));
            parts.Add((new Part(1, Program.List.Schraube38)));
            
            job = new Job(JobId.FahrradOhnePedaleH, station, parts, 20, 6, Program.List.FahrradOhnePedaleH);
            jobs.Add(job);
            
            this.JobsByStation.Add(station, jobs);
            
            
            
            //Vierte Station
            
            station = new Workstation(StationId.Vier, .05, .01);
            jobs = new List<Job>();
            
            //Kinder
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.FahrradOhnePedaleK)));
            parts.Add((new Part(1, Program.List.PedalCpl)));
            parts.Add((new Part(1, Program.List.KetteK)));
            parts.Add((new Part(1, Program.List.Mutter38)));
            parts.Add((new Part(1, Program.List.Schraube38)));
            
            job = new Job(JobId.FahrradComplK, station, parts, 30, 6, Program.List.Kinderfahrrad);
            jobs.Add(job);

            //Damen
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.FahrradOhnePedaleD)));
            parts.Add((new Part(1, Program.List.PedalCpl)));
            parts.Add((new Part(1, Program.List.KetteD)));
            parts.Add((new Part(1, Program.List.Mutter38)));
            parts.Add((new Part(1, Program.List.Schraube38)));
            
            job = new Job(JobId.FahrradComplD, station, parts, 20, 7, Program.List.Damenfahrrad);
            jobs.Add(job);

            //Herren
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.FahrradOhnePedaleH)));
            parts.Add((new Part(1, Program.List.PedalCpl)));
            parts.Add((new Part(1, Program.List.KetteH)));
            parts.Add((new Part(1, Program.List.Mutter38)));
            parts.Add((new Part(1, Program.List.Schraube38)));
            
            job = new Job(JobId.FahrradComplH, station, parts, 30, 7, Program.List.Herrenfahrrad);
            jobs.Add(job);
            
            this.JobsByStation.Add(station, jobs);
            
            
            
            //Vierzehnte Station
            station = new Workstation(StationId.Vierzehn, .05, .01);
			jobs = new List<Job>();
			
			//Kinder
			parts = new List<Part>();
			parts.Add((new Part(1, Program.List.Mutter38)));
           	parts.Add((new Part(1, Program.List.Lenker)));										// wirklich Lenker?
           	parts.Add((new Part(2, Program.List.Griff)));
           	parts.Add((new Part(1, Program.List.Mutter34)));

			job = new Job(JobId.LenkermontageK, station, parts, 0, 3, Program.List.LenkerCpl);
            jobs.Add(job);
            
            //Damen
            parts = new List<Part>();
			parts.Add((new Part(1, Program.List.Mutter38)));
           	parts.Add((new Part(1, Program.List.Lenker)));						
           	parts.Add((new Part(2, Program.List.Griff)));
           	parts.Add((new Part(1, Program.List.Mutter34)));

			job = new Job(JobId.LenkermontageD, station, parts, 0, 3, Program.List.LenkerCpl);
            jobs.Add(job);
            
            //Herren
            parts = new List<Part>();
			parts.Add((new Part(1, Program.List.Mutter38)));
           	parts.Add((new Part(1, Program.List.Lenker)));							
           	parts.Add((new Part(2, Program.List.Griff)));
           	parts.Add((new Part(1, Program.List.Mutter34)));

			job = new Job(JobId.LenkermontageH, station, parts, 0, 3, Program.List.LenkerCpl);
            jobs.Add(job);
            
            this.JobsByStation.Add(station, jobs);
            
            
            
            //Sechste Station
            
            station = new Workstation(StationId.Sechs, .3, .1);
            jobs = new List<Job>();
            
            //Kinder
            parts = new List<Part>();
            parts.Add((new Part(3, Program.List.Rohr34)));

            job = new Job(JobId.BiegemaschineRahmenK, station, parts, 15, 3, JobId.StanzeRahmenK);
            jobs.Add(job);

            //Damen
            parts = new List<Part>();
            parts.Add((new Part(4, Program.List.Rohr34)));
            
            job = new Job(JobId.BiegemaschineRahmenD, station, parts, 15, 3, JobId.StanzeRahmenD);
            jobs.Add(job);

            //Herren
            parts = new List<Part>();
            parts.Add((new Part(5, Program.List.Rohr34)));
            
            job = new Job(JobId.BiegemaschineRahmenH, station, parts, 15, 3, JobId.StanzeRahmenH);
            jobs.Add(job);
            
            //Kinder - 2
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.Rohr34)));
            
            job = new Job(JobId.RohrbiegemaschineK, station, parts, 15, 2, JobId.LenkermontageK);
            jobs.Add(job);
            
            //Damen - 2
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.Rohr34)));
            
            job = new Job(JobId.RohrbiegemaschineD, station, parts, 15, 2, JobId.LenkermontageD);
            jobs.Add(job);
            
            //Herren - 2
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.Rohr34)));
            
            job = new Job(JobId.RohrbiegemaschineH, station, parts, 15, 2, JobId.LenkermontageH);
            jobs.Add(job);
            
            this.JobsByStation.Add(station, jobs);
            
            
            
            //Neunte Station
			station = new Workstation(StationId.Neun, .8, .25);
           	jobs = new List<Job>();		

			//Kinder
			parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.Farbe)));

			job = new Job(JobId.LackierplatzSchutzblechVorneK, station, parts, 15, 3, Program.List.SchutzblechVorneK);
            jobs.Add(job);

			//Damen
			parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.Farbe)));

			job = new Job(JobId.LackierplatzSchutzblechVorneD, station, parts, 15, 3, Program.List.SchutzblechVorneD);
            jobs.Add(job);	

			//Herren
			parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.Farbe)));

			job = new Job(JobId.LackierplatzSchutzblechVorneH, station, parts, 15, 3, Program.List.SchutzblechVorneH);
            jobs.Add(job);	
	

			//Kinder - 2
			parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.Farbe)));

			job = new Job(JobId.LackierplatzRahmenK, station, parts, 15, 2, Program.List.RahmenK);
            jobs.Add(job);

			//Damen - 2
			parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.Farbe)));

			job = new Job(JobId.LackierplatzRahmenD, station, parts, 20, 2, Program.List.RahmenD);
            jobs.Add(job);	

			//Herren - 2
			parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.Farbe)));

			job = new Job(JobId.LackierplatzRahmenH, station, parts, 15, 2, Program.List.RahmenH);
            jobs.Add(job);
	

			//Kinder - 3
			parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.Farbe)));

			job = new Job(JobId.LackierplatzSchutzblechHintenK, station, parts, 15, 3, Program.List.SchutzblechHintenK);
            jobs.Add(job);

			//Damen - 3
			parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.Farbe)));

			job = new Job(JobId.LackierplatzSchutzblechHintenD, station, parts, 15, 3, Program.List.SchutzblechHintenD);
            jobs.Add(job);	

			//Herren - 3
			parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.Farbe)));

			job = new Job(JobId.LackierplatzSchutzblechHintenH, station, parts, 15, 3, Program.List.SchutzblechHintenH);
            jobs.Add(job);
            
            this.JobsByStation.Add(station, jobs);
            
            
            
            //Fuenfzehnte Station
            station = new Workstation(StationId.Fuenfzehn, .05, .01);
			jobs = new List<Job>();		

			//Kinder
			parts = new List<Part>();
			parts.Add((new Part(1, Program.List.Sattel)));
			parts.Add((new Part(1, Program.List.Stange12)));
			parts.Add((new Part(1, Program.List.Mutter14)));
			parts.Add((new Part(1, Program.List.Schraube14)));

			job = new Job(JobId.SattelmontageComplK, station, parts, 15, 3, Program.List.SattelCpl);
            jobs.Add(job);	
            
            //Damen
            parts = new List<Part>();
			parts.Add((new Part(1, Program.List.Sattel)));
			parts.Add((new Part(1, Program.List.Stange12)));
			parts.Add((new Part(1, Program.List.Mutter14)));
			parts.Add((new Part(1, Program.List.Schraube14)));

			job = new Job(JobId.SattelmontageComplD, station, parts, 15, 3, Program.List.SattelCpl);
            jobs.Add(job);
            
            //Herren
            parts = new List<Part>();
			parts.Add((new Part(1, Program.List.Sattel)));
			parts.Add((new Part(1, Program.List.Stange12)));
			parts.Add((new Part(1, Program.List.Mutter14)));
			parts.Add((new Part(1, Program.List.Schraube14)));

			job = new Job(JobId.SattelmontageComplH, station, parts, 15, 3, Program.List.SattelCpl);
            jobs.Add(job);
	

			//Kinder - 2
			parts = new List<Part>();
			parts.Add((new Part(1, Program.List.Zahnkranz)));

			job = new Job(JobId.PedalmontageK, station, parts, 15, 3, Program.List.PedalCpl);
            jobs.Add(job);	
		
			//Damen - 2
			parts = new List<Part>();
			parts.Add((new Part(1, Program.List.Zahnkranz)));

			job = new Job(JobId.PedalmontageD, station, parts, 15, 3, Program.List.PedalCpl);
            jobs.Add(job);

			//Herren - 2
			parts = new List<Part>();
			parts.Add((new Part(1, Program.List.Zahnkranz)));

			job = new Job(JobId.PedalmontageH, station, parts, 15, 3, Program.List.PedalCpl);
            jobs.Add(job);
            
            this.JobsByStation.Add(station, jobs);
            

            
            //Siebte Station
            station = new Workstation(StationId.Sieben, .3, .1);
            jobs = new List<Job>();
            
            //Kinder
            job = new Job(JobId.SchweissplatzSchutzblechVorneK, station, null, 20, 2, JobId.LackierplatzSchutzblechVorneK);
            jobs.Add(job);
            
            //Damen
            job = new Job(JobId.SchweissplatzSchutzblechVorneD, station, null, 20, 2, JobId.LackierplatzSchutzblechVorneD);
            jobs.Add(job);
            
            //Herren
            job = new Job(JobId.SchweissplatzSchutzblechVorneH, station, null, 20, 2, JobId.LackierplatzSchutzblechVorneH);
            jobs.Add(job);
            
            
			//Kinder - 2
			parts = new List<Part>();
           	parts.Add((new Part(2, Program.List.Schweissdraht)));

			job = new Job(JobId.SchweissplatzRahmenK, station, parts, 20, 2, JobId.LackierplatzRahmenK);
            jobs.Add(job);	

			//Damen - 2
			parts = new List<Part>();
           	parts.Add((new Part(2, Program.List.Schweissdraht)));

			job = new Job(JobId.SchweissplatzRahmenD, station, parts, 20, 2, JobId.LackierplatzRahmenD);
            jobs.Add(job);

			//Herren - 2
			parts = new List<Part>();
           	parts.Add((new Part(2, Program.List.Schweissdraht)));

			job = new Job(JobId.SchweissplatzRahmenH, station, parts, 20, 2, JobId.LackierplatzRahmenH);
            jobs.Add(job);

            
            //Kinder - 3
            job = new Job(JobId.SchweissplatzSchutzblechHintenK, station, null, 20, 2, JobId.LackierplatzSchutzblechHintenK);
            jobs.Add(job);
            
            //Damen - 3
            job = new Job(JobId.SchweissplatzSchutzblechHintenD, station, null, 20, 2, JobId.LackierplatzSchutzblechHintenD);
            jobs.Add(job);
			     
            //Herren - 3
            job = new Job(JobId.SchweissplatzSchutzblechHintenH, station, null, 20, 2, JobId.LackierplatzSchutzblechHintenH);
            jobs.Add(job);
            

			//Kinder - 4
			parts = new List<Part>();
           	parts.Add((new Part(2, Program.List.Pedale)));
			parts.Add((new Part(2, Program.List.Stange12)));

			job = new Job(JobId.SchweissplatzPedaleK, station, parts, 30, 2, JobId.PedalmontageK);
            jobs.Add(job);	

			//Damen - 4
			parts = new List<Part>();
           	parts.Add((new Part(2, Program.List.Pedale)));
			parts.Add((new Part(2, Program.List.Stange12)));

			job = new Job(JobId.SchweissplatzPedaleD, station, parts, 30, 2, JobId.PedalmontageD);
            jobs.Add(job);

			//Herren - 4
			parts = new List<Part>();
           	parts.Add((new Part(2, Program.List.Pedale)));
			parts.Add((new Part(2, Program.List.Stange12)));

			job = new Job(JobId.SchweissplatzPedaleH, station, parts, 30, 2, JobId.PedalmontageH);
            jobs.Add(job);
            
            this.JobsByStation.Add(station, jobs);
            
            
          
            //Achte Station
            station = new Workstation(StationId.Acht, .3, .1);
            jobs = new List<Job>();
            
            //Kinder
            job = new Job(JobId.StanzeSchutzblechVorneK, station, null, 15, 1, JobId.SchweissplatzSchutzblechVorneK);
            jobs.Add(job);
            
            //Damen
            job = new Job(JobId.StanzeSchutzblechVorneD, station, null, 15, 2, JobId.SchweissplatzSchutzblechVorneD);
            jobs.Add(job);
            
            //Herren
            job = new Job(JobId.StanzeSchutzblechVorneH, station, null, 15, 2, JobId.SchweissplatzSchutzblechVorneH);
            jobs.Add(job);
            
            
            //Kinder - 2
            job = new Job(JobId.StanzeRahmenK, station, null, 20, 3, JobId.SchweissplatzRahmenK);
            jobs.Add(job);
            
            //Damen - 2
            job = new Job(JobId.StanzeRahmenD, station, null, 25, 3, JobId.SchweissplatzRahmenD);
            jobs.Add(job);
            
            //Herren - 2
            job = new Job(JobId.StanzeRahmenH, station, null, 20, 3, JobId.SchweissplatzRahmenH);
            jobs.Add(job);
            
            
            //Kinder - 3
            job = new Job(JobId.StanzeSchutzblechHintenK, station, null, 15, 1, JobId.SchweissplatzSchutzblechHintenK);
            jobs.Add(job);
            
            //Damen - 3
            job = new Job(JobId.StanzeSchutzblechHintenD, station, null, 15, 2, JobId.SchweissplatzSchutzblechHintenD);
            jobs.Add(job);
            
            //Herren - 3
            job = new Job(JobId.StanzeSchutzblechHintenH, station, null, 15, 2, JobId.SchweissplatzSchutzblechHintenH);
            jobs.Add(job);
            
            this.JobsByStation.Add(station, jobs);
            
            
            
            //Zwoelfte Station
            station = new Workstation(StationId.Zwoelf, .3, .1);
           	jobs = new List<Job>();
           	
           	//Kinder
           	job = new Job(JobId.BiegemaschineSchutzblechVorneK, station, null, 0, 3, JobId.StanzeSchutzblechVorneK);
           	jobs.Add(job);
           	
           	//Damen
           	job = new Job(JobId.BiegemaschineSchutzblechVorneD, station, null, 0, 3, JobId.StanzeSchutzblechVorneD);
           	jobs.Add(job);
           	
           	//Herren
           	job = new Job(JobId.BiegemaschineSchutzblechVorneH, station, null, 0, 3, JobId.StanzeSchutzblechVorneH);
           	jobs.Add(job);
            
           	
           	//Kinder - 2
           	job = new Job(JobId.BiegemaschineSchutzblechHintenK, station, null, 0, 3, JobId.StanzeSchutzblechHintenK);
           	jobs.Add(job);
           	
           	//Damen - 2
           	job = new Job(JobId.BiegemaschineSchutzblechHintenD, station, null, 0, 3, JobId.StanzeSchutzblechHintenD);
           	jobs.Add(job);
           	
           	//Herren - 2
           	job = new Job(JobId.BiegemaschineSchutzblechHintenH, station, null, 0, 3, JobId.StanzeSchutzblechHintenH);
           	jobs.Add(job);
           	
           	this.JobsByStation.Add(station, jobs);
           	
           
           	
           	//Dreizehnte Station
			station = new Workstation(StationId.Dreizehn, .5, .15);
           	jobs = new List<Job>();		

			//Kinder      
			parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.Blech)));

			job = new Job(JobId.BlechschereSchutzblechVorneK, station, parts, 0, 2, JobId.BiegemaschineSchutzblechVorneK);
            jobs.Add(job);	

			//Damen
			parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.Blech)));

			job = new Job(JobId.BlechschereSchutzblechVorneD, station, parts, 0, 2, JobId.BiegemaschineSchutzblechVorneD);
            jobs.Add(job);
            
            //Herren
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.Blech)));

			job = new Job(JobId.BlechschereSchutzblechVorneH, station, parts, 0, 2, JobId.BiegemaschineSchutzblechVorneH);
            jobs.Add(job);
            
            
            //Kinder - 2
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.Blech)));
           
            job = new Job(JobId.BlechschereSchutzblechHintenK, station, parts, 0, 2, JobId.BiegemaschineSchutzblechHintenK);
            jobs.Add(job);
            
            //Damen - 2
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.Blech)));
           
            job = new Job(JobId.BlechschereSchutzblechHintenD, station, parts, 0, 2, JobId.BiegemaschineSchutzblechHintenD);
            jobs.Add(job);
            
            //Herren - 2
            parts = new List<Part>();
            parts.Add((new Part(1, Program.List.Blech)));
           
            job = new Job(JobId.BlechschereSchutzblechHintenH, station, parts, 0, 2, JobId.BiegemaschineSchutzblechHintenH);
            jobs.Add(job);
            
            this.JobsByStation.Add(station, jobs);

            
           	
           	//Elfte Station
           	station = new Workstation(StationId.Elf, .3, .1);
           	jobs = new List<Job>();
           	
           	//Kinder
           	parts = new List<Part>();
           	parts.Add((new Part(2, Program.List.Nabe)));
           	parts.Add((new Part(1, Program.List.Gabel)));
           	parts.Add((new Part(1, Program.List.Welle)));
           		                              
           	job = new Job(JobId.VorderradNabenMontageK, station, parts, 20, 3, Program.List.VorderradgruppeK);
           	jobs.Add(job);
           		                              
           	//Damen
           	parts = new List<Part>();
            parts.Add((new Part(2, Program.List.Nabe)));
           	parts.Add((new Part(1, Program.List.Gabel)));
           	parts.Add((new Part(1, Program.List.Welle)));
           	                              
           	job = new Job(JobId.VorderradNabenMontageD, station, parts, 20, 3, Program.List.VorderradgruppeD);
           	jobs.Add(job);

			//Herren
			parts = new List<Part>();
            parts.Add((new Part(2, Program.List.Nabe)));
           	parts.Add((new Part(1, Program.List.Gabel)));
           	parts.Add((new Part(1, Program.List.Welle)));
           	                              
           	job = new Job(JobId.VorderradNabenMontageH, station, parts, 20, 3, Program.List.VorderradgruppeH);
           	jobs.Add(job);
           	
           	
           	//Kinder - 2
           	parts = new List<Part>();
           	parts.Add((new Part(2, Program.List.Nabe)));
           	parts.Add((new Part(1, Program.List.Freilauf)));
           		                              
           	job = new Job(JobId.HinterradNabenMontageK, station, parts, 10, 3, Program.List.HinterradgruppeK);
           	jobs.Add(job);      

           	//Damen - 2
           	parts = new List<Part>();
           	parts.Add((new Part(2, Program.List.Nabe)));
           	parts.Add((new Part(1, Program.List.Freilauf)));	

			job = new Job(JobId.HinterradNabenMontageD, station, parts, 10, 3, Program.List.HinterradgruppeD);
           	jobs.Add(job);
           	
			//Herren - 2 
			parts = new List<Part>();
           	parts.Add((new Part(2, Program.List.Nabe)));
           	parts.Add((new Part(1, Program.List.Freilauf)));	

			job = new Job(JobId.HinterradNabenMontageH, station, parts, 20, 3, Program.List.HinterradgruppeH);
           	jobs.Add(job);  
           	
           	this.JobsByStation.Add(station, jobs);
           	
           	
           	
           	//Zehnte Station
           	station = new Workstation(StationId.Zehn, .3, .1);
           	jobs = new List<Job>();
           	
           	//Kinder
           	parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.FelgeCplK)));
          	parts.Add((new Part(36, Program.List.SpeicheK)));
           	                    
           	job = new Job(JobId.RadmontageVorneK, station, parts, 20, 4, JobId.VorderradNabenMontageK);
            jobs.Add(job);
            
            //Damen
            parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.FelgeCplD)));
          	parts.Add((new Part(36, Program.List.SpeicheD)));
                                
           	job = new Job(JobId.RadmontageVorneD, station, parts, 20, 4, JobId.VorderradNabenMontageD);
           	jobs.Add(job);
           	
           	//Herren
           	parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.FelgeCplH)));
          	parts.Add((new Part(36, Program.List.SpeicheH)));
           	                    
           	job = new Job(JobId.RadmontageVorneH, station, parts, 20, 4, JobId.VorderradNabenMontageH);
           	jobs.Add(job);
           	
           	
           	//Kinder - 2
           	parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.FelgeCplK)));
          	parts.Add((new Part(36, Program.List.SpeicheK)));
           	                    
           	job = new Job(JobId.RadmontageHintenK, station, parts, 20, 4, JobId.HinterradNabenMontageK);
            jobs.Add(job);
            
            //Damen - 2
            parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.FelgeCplD)));
          	parts.Add((new Part(36, Program.List.SpeicheD)));
                                
           	job = new Job(JobId.RadmontageHintenD, station, parts, 20, 4, JobId.HinterradNabenMontageD);
           	jobs.Add(job);
           	
           	//Herren - 2
           	parts = new List<Part>();
           	parts.Add((new Part(1, Program.List.FelgeCplH)));
          	parts.Add((new Part(36, Program.List.SpeicheH)));
           	                    
           	job = new Job(JobId.RadmontageHintenH, station, parts, 20, 4, JobId.HinterradNabenMontageH);
           	jobs.Add(job);
           	
           	this.JobsByStation.Add(station, jobs);	            
        }

        //Dictionary
        public Dictionary<Workstation, List<Job>> JobsByStation { get; private set; }

        //für einfacheres Ansprechen, prinzipiell unnötig
        public List<Job> GetJobsByStation(Workstation station)
        {
            List<Job> result;
            this.JobsByStation.TryGetValue(station, out result);
            return result;
        }

        public List<Workstation> Workstations
        {
            get 
            {
                List<Workstation> result = new List<Workstation>();
                foreach (KeyValuePair<Workstation, List<Job>> kvp in this.JobsByStation)
                {

                    result.Add(kvp.Key);
                }
                return result;
            }
        }
    }
}
