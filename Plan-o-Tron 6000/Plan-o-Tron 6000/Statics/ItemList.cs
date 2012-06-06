using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plan_o_Tron_6000.Statics
{
    /// <summary>
    /// Statisch Klasse die Informationen zu den einzelnen Teilen hält
    /// </summary>
    public class ItemList
    {
        public List<Item> Items;

        #region P-Teile
        public readonly Item Kinderfahrrad;
        public readonly Item Damenfahrrad;
        public readonly Item Herrenfahrrad;

        #endregion

        #region E-Teile
        public readonly Item HinterradgruppeK;
        public readonly Item HinterradgruppeD;
        public readonly Item HinterradgruppeH;
        public readonly Item VorderradgruppeK;
        public readonly Item VorderradgruppeD;
        public readonly Item VorderradgruppeH;
        public readonly Item SchutzblechHintenK;
        public readonly Item SchutzblechHintenD;
        public readonly Item SchutzblechHintenH;
        public readonly Item SchutzblechVorneK;
        public readonly Item SchutzblechVorneD;
        public readonly Item SchutzblechVorneH;
        public readonly Item LenkerCpl;
        public readonly Item SattelCpl;
        public readonly Item RahmenK;
        public readonly Item RahmenD;
        public readonly Item RahmenH;
        public readonly Item PedalCpl;
        public readonly Item VorderradMontH;
        public readonly Item RahmenUndRaederH;
        public readonly Item FahrradOhnePedaleH;
        public readonly Item VorderradMontK;
        public readonly Item RahmenUndRaederK;
        public readonly Item FahrradOhnePedaleK;
        public readonly Item VorderradMontD;
        public readonly Item RahmenUndRaederD;
        public readonly Item FahrradOhnePedaleD;
        #endregion

        #region K-Teile
        public readonly Item KetteK;
        public readonly Item KetteD;
        public readonly Item KetteH;
        public readonly Item Mutter38;
        public readonly Item Scheibe38;
        public readonly Item Schraube38;
        public readonly Item Rohr34;
        public readonly Item Farbe;
        public readonly Item SpeicheH;
        public readonly Item Nabe;
        public readonly Item Freilauf;
        public readonly Item Gabel;
        public readonly Item Welle;
        public readonly Item Blech;
        public readonly Item Lenker;
        public readonly Item Mutter34;
        public readonly Item Griff;
        public readonly Item Sattel;
        public readonly Item Stange12;
        public readonly Item Mutter14;
        public readonly Item Schraube14;
        public readonly Item Zahnkranz;
        public readonly Item Pedale;
        public readonly Item SpeicheK;
        public readonly Item SpeicheD;
        public readonly Item Schweissdraht;
        public readonly Item FelgeCplH;
        public readonly Item FelgeCplK;
        public readonly Item FelgeCplD;
        #endregion

        public ItemList()
        {
            Items = new List<Item>();
            List<Part> parts = new List<Part>();

         //K teile zu erst deklarieren da abhängigkeiten bestehen
        #region K Teile
        this.KetteK = new Item(ItemId.KetteK, null);
        this.KetteD = new Item(ItemId.KetteD, null);
        this.KetteH = new Item(ItemId.KetteH, null);
        this.Mutter38 = new Item(ItemId.Mutter38, null);
        this.Scheibe38 = new Item(ItemId.Scheibe38, null);
        this.Schraube38 = new Item(ItemId.Schraube38, null);
        this.Rohr34 = new Item(ItemId.Rohr34, null);
        this.Farbe = new Item(ItemId.Farbe, null);
        this.SpeicheH = new Item(ItemId.SpeicheH, null);
        this.Nabe = new Item(ItemId.Nabe, null);
        this.Freilauf = new Item(ItemId.Freilauf, null);
        this.Gabel = new Item(ItemId.Gabel, null);
        this.Welle = new Item(ItemId.Welle, null);
        this.Blech = new Item(ItemId.Blech, null);
        this.Lenker = new Item(ItemId.Lenker, null);
        this.Mutter34 = new Item(ItemId.Mutter34, null);
        this.Griff = new Item(ItemId.Griff, null);
        this.Sattel = new Item(ItemId.Sattel, null);
        this.Stange12 = new Item(ItemId.Stange12, null);
        this.Mutter14 = new Item(ItemId.Mutter14, null);
        this.Schraube14 = new Item(ItemId.Schraube14, null);
        this.Zahnkranz = new Item(ItemId.Zahnkranz, null);
        this.Pedale = new Item(ItemId.Pedale, null);
        this.SpeicheK = new Item(ItemId.SpeicheK, null);
        this.SpeicheD = new Item(ItemId.SpeicheD, null);
        this.Schweissdraht = new Item(ItemId.Schweissdraht, null);
        this.FelgeCplH = new Item(ItemId.FelgeCplH, null);
        this.FelgeCplK = new Item(ItemId.FelgeCplK, null);
        this.FelgeCplD = new Item(ItemId.FelgeCplD, null);

        //in Liste
        this.Items.Add(this.KetteK);
        this.Items.Add(this.KetteD);
        this.Items.Add(this.KetteH);
        this.Items.Add(this.Mutter38);
        this.Items.Add(this.Scheibe38);
        this.Items.Add(this.Schraube38);
        this.Items.Add(this.Rohr34);
        this.Items.Add(this.Farbe);
        this.Items.Add(this.SpeicheH);
        this.Items.Add(this.Nabe);
        this.Items.Add(this.Freilauf);
        this.Items.Add(this.Gabel);
        this.Items.Add(this.Welle);
        this.Items.Add(this.Blech);
        this.Items.Add(this.Lenker);
        this.Items.Add(this.Mutter34);
        this.Items.Add(this.Griff);
        this.Items.Add(this.Sattel);
        this.Items.Add(this.Stange12);
        this.Items.Add(this.Mutter14);
        this.Items.Add(this.Schraube14);
        this.Items.Add(this.Zahnkranz);
        this.Items.Add(this.Pedale);
        this.Items.Add(this.SpeicheK);
        this.Items.Add(this.SpeicheD);
        this.Items.Add(this.Schweissdraht);
        this.Items.Add(this.FelgeCplH);
        this.Items.Add(this.FelgeCplK);
        this.Items.Add(this.FelgeCplD);

        #endregion


        #region E-Teile
        //E4
        parts.Clear();
        parts.Add(new Part(2, this.Nabe));
        parts.Add(new Part(1, this.Freilauf));
        parts.Add(new Part(1, this.FelgeCplK));
        parts.Add(new Part(36, this.SpeicheK));
        this.HinterradgruppeK = new Item(ItemId.HinterradgruppeK, new List<Part>(parts));
        this.Items.Add(this.HinterradgruppeK);
        
        //E5
        parts.Clear();
        parts.Add(new Part(2, this.Nabe));
        parts.Add(new Part(1, this.Freilauf));
        parts.Add(new Part(1, this.FelgeCplD));
        parts.Add(new Part(36, this.SpeicheD));
        this.HinterradgruppeD = new Item(ItemId.HinterradgruppeD, new List<Part>(parts));
        this.Items.Add(this.HinterradgruppeD);
        
        //E6
        parts.Clear();
        parts.Add(new Part(2, this.Nabe));
        parts.Add(new Part(1, this.Freilauf));
        parts.Add(new Part(1, this.FelgeCplH));
        parts.Add(new Part(36, this.SpeicheH));
        this.HinterradgruppeH = new Item(ItemId.HinterradgruppeH, new List<Part>(parts));
        this.Items.Add(this.HinterradgruppeH);
        
        //E7
        parts.Clear();
        parts.Add(new Part(2, this.Nabe));
        parts.Add(new Part(1, this.Gabel));
        parts.Add(new Part(1, this.Welle));
        parts.Add(new Part(1, this.FelgeCplK));
        parts.Add(new Part(36, this.SpeicheK));
        this.VorderradgruppeK = new Item(ItemId.VorderradgruppeK, new List<Part>(parts));
        this.Items.Add(this.VorderradgruppeK);
        
        //E8
        parts.Clear();
        parts.Add(new Part(2, this.Nabe));
        parts.Add(new Part(1, this.Gabel));
        parts.Add(new Part(1, this.Welle));
        parts.Add(new Part(1, this.FelgeCplD));
        parts.Add(new Part(36, this.SpeicheD));
        this.VorderradgruppeD = new Item(ItemId.VorderradgruppeD, new List<Part>(parts));
        this.Items.Add(this.VorderradgruppeD);
        
        //E9
        parts.Clear();
        parts.Add(new Part(2, this.Nabe));
        parts.Add(new Part(1, this.Gabel));
        parts.Add(new Part(1, this.Welle));
        parts.Add(new Part(1, this.FelgeCplH));
        parts.Add(new Part(36, this.SpeicheH));
        this.VorderradgruppeH = new Item(ItemId.VorderradgruppeH, new List<Part>(parts));
        this.Items.Add(this.VorderradgruppeH);
        
        //E10
        parts.Clear();
        parts.Add(new Part(1, this.Farbe));
        parts.Add(new Part(1, this.Blech));
        this.SchutzblechHintenK = new Item(ItemId.SchutzblechHintenK, new List<Part>(parts));
        this.Items.Add(this.SchutzblechHintenK);
        
        //E11
        parts.Clear();
        parts.Add(new Part(1, this.Farbe));
        parts.Add(new Part(1, this.Blech));
        this.SchutzblechHintenD = new Item(ItemId.SchutzblechHintenD, new List<Part>(parts));
        this.Items.Add(this.SchutzblechHintenD);

		//E12        
        parts.Clear();
        parts.Add(new Part(1, this.Farbe));
        parts.Add(new Part(1, this.Blech));
        this.SchutzblechHintenH = new Item(ItemId.SchutzblechHintenH, new List<Part>(parts));
        this.Items.Add(this.SchutzblechHintenH);
        
        //E13
        parts.Clear();
        parts.Add(new Part(1, this.Farbe));
        parts.Add(new Part(1, this.Blech));
        this.SchutzblechVorneK = new Item(ItemId.SchutzblechVorneK, new List<Part>(parts));
        this.Items.Add(this.SchutzblechVorneK);

		//E14
        parts.Clear();
        parts.Add(new Part(1, this.Farbe));
        parts.Add(new Part(1, this.Blech));
        this.SchutzblechVorneD = new Item(ItemId.SchutzblechVorneD, new List<Part>(parts));
        this.Items.Add(this.SchutzblechVorneD);
        
        
		//E15
        parts.Clear();
        parts.Add(new Part(1, this.Farbe));
        parts.Add(new Part(1, this.Blech));
        this.SchutzblechVorneH = new Item(ItemId.SchutzblechVorneH, new List<Part>(parts));
        this.Items.Add(this.SchutzblechVorneH);
        
        //E16
        parts.Clear();
        parts.Add(new Part(1, this.Mutter38));
        parts.Add(new Part(1, this.Rohr34));
        parts.Add(new Part(1, this.Lenker));
        parts.Add(new Part(1, this.Mutter34));
        parts.Add(new Part(2, this.Griff));
        this.LenkerCpl = new Item(ItemId.LenkerCpl, new List<Part>(parts));
        this.Items.Add(this.LenkerCpl);

        //E17
        parts.Clear();
        parts.Add(new Part(1, this.Sattel));
        parts.Add(new Part(1, this.Stange12));
        parts.Add(new Part(1, this.Mutter14));
        parts.Add(new Part(1, this.Schraube14));
        this.SattelCpl = new Item(ItemId.SattelCpl, new List<Part>(parts));
        this.Items.Add(this.SattelCpl);

        //E18
        parts.Clear();
        parts.Add(new Part(3, this.Rohr34));
        parts.Add(new Part(1, this.Farbe));
        parts.Add(new Part(2, this.Schweissdraht));
        this.RahmenK = new Item(ItemId.RahmenK, new List<Part>(parts));
        this.Items.Add(this.RahmenK);

        //E19
        parts.Clear();
        parts.Add(new Part(4, this.Rohr34));
        parts.Add(new Part(1, this.Farbe));
        parts.Add(new Part(2, this.Schweissdraht));
        this.RahmenD = new Item(ItemId.RahmenD, new List<Part>(parts));
        this.Items.Add(this.RahmenD);

        //E20
        parts.Clear();
        parts.Add(new Part(5, this.Rohr34));
        parts.Add(new Part(1, this.Farbe));
        parts.Add(new Part(2, this.Schweissdraht));
        this.RahmenH = new Item(ItemId.RahmenH, new List<Part>(parts));
        this.Items.Add(this.RahmenH);

        //E26
        parts.Clear();
        parts.Add(new Part(2, this.Stange12));
        parts.Add(new Part(1, this.Zahnkranz));
        parts.Add(new Part(2, this.Pedale));
        this.PedalCpl = new Item(ItemId.PedalCpl, new List<Part>(parts));
        this.Items.Add(this.PedalCpl);

        //E29
        parts.Clear();
        parts.Add(new Part(2, this.Mutter38));
        parts.Add(new Part(2, this.Scheibe38));
        parts.Add(new Part(1, this.VorderradgruppeH));
        parts.Add(new Part(1, this.SchutzblechVorneH));
        parts.Add(new Part(1, this.RahmenH));
        this.VorderradMontH = new Item(ItemId.VorderradMontH, new List<Part>(parts));
        this.Items.Add(this.VorderradMontH);

        //E30
        parts.Clear();
        parts.Add(new Part(2, this.Mutter38));
        parts.Add(new Part(2, this.Scheibe38));
        parts.Add(new Part(1, this.HinterradgruppeH));
        parts.Add(new Part(1, this.SchutzblechHintenH));
        parts.Add(new Part(1, this.VorderradMontH));
        this.RahmenUndRaederH = new Item(ItemId.RahmenUndRaederH, new List<Part>(parts));
        this.Items.Add(this.RahmenUndRaederH);

        //E31
        parts.Clear();
        parts.Add(new Part(1, this.Mutter38));
        parts.Add(new Part(1, this.Schraube38));
        parts.Add(new Part(1, this.LenkerCpl));
        parts.Add(new Part(1, this.SattelCpl));
        parts.Add(new Part(1, this.RahmenUndRaederH));
        this.FahrradOhnePedaleH = new Item(ItemId.FahrradOhnePedaleH, new List<Part>(parts));
        this.Items.Add(this.FahrradOhnePedaleH);

        //E49
        parts.Clear();
        parts.Add(new Part(2, this.Mutter38));
        parts.Add(new Part(2, this.Scheibe38));
        parts.Add(new Part(1, this.VorderradgruppeK));
        parts.Add(new Part(1, this.SchutzblechVorneK));
        parts.Add(new Part(1, this.RahmenK));
        this.VorderradMontK = new Item(ItemId.VorderradMontK, new List<Part>(parts));
        this.Items.Add(this.VorderradMontK);

        //E50
        parts.Clear();
        parts.Add(new Part(2, this.Mutter38));
        parts.Add(new Part(2, this.Scheibe38));
        parts.Add(new Part(1, this.HinterradgruppeK));
        parts.Add(new Part(1, this.SchutzblechHintenK));
        parts.Add(new Part(1, this.VorderradMontK));
        this.RahmenUndRaederK = new Item(ItemId.RahmenUndRaederK, new List<Part>(parts));
        this.Items.Add(this.RahmenUndRaederK);

        //E51
        parts.Clear();
        parts.Add(new Part(1, this.Mutter38));
        parts.Add(new Part(1, this.Schraube38));
        parts.Add(new Part(1, this.LenkerCpl));
        parts.Add(new Part(1, this.SattelCpl));
        parts.Add(new Part(1, this.RahmenUndRaederK));
        this.FahrradOhnePedaleK = new Item(ItemId.FahrradOhnePedaleK, new List<Part>(parts));
        this.Items.Add(this.FahrradOhnePedaleK);

        //E54
        parts.Clear();
        parts.Add(new Part(2, this.Mutter38));
        parts.Add(new Part(2, this.Scheibe38));
        parts.Add(new Part(1, this.VorderradgruppeD));
        parts.Add(new Part(1, this.SchutzblechVorneD));
        parts.Add(new Part(1, this.RahmenD));
        this.VorderradMontD = new Item(ItemId.VorderradMontD, new List<Part>(parts));
        this.Items.Add(this.VorderradMontD);

        //E55
        parts.Clear();
        parts.Add(new Part(2, this.Mutter38));
        parts.Add(new Part(2, this.Scheibe38));
        parts.Add(new Part(1, this.HinterradgruppeD));
        parts.Add(new Part(1, this.SchutzblechHintenD));
        parts.Add(new Part(1, this.VorderradMontD));
        this.RahmenUndRaederD = new Item(ItemId.RahmenUndRaederD, new List<Part>(parts));
        this.Items.Add(this.RahmenUndRaederD);

        //E56
        parts.Clear();
        parts.Add(new Part(1, this.Mutter38));
        parts.Add(new Part(1, this.Schraube38));
        parts.Add(new Part(1, this.LenkerCpl));
        parts.Add(new Part(1, this.SattelCpl));
        parts.Add(new Part(1, this.RahmenUndRaederD));
        this.FahrradOhnePedaleD = new Item(ItemId.FahrradOhnePedaleD, new List<Part>(parts));
        this.Items.Add(this.FahrradOhnePedaleD);

        #endregion



        #region Produkte
        //Kinderfahrrad
            parts.Clear(); // Liste leeren
            parts.Add(new Part(1, this.KetteK)); //item hinzufügen
			parts.Add(new Part(1, this.Mutter38));
			parts.Add(new Part(1, this.Schraube38));
			parts.Add(new Part(1, this.PedalCpl));
			parts.Add(new Part(1, this.FahrradOhnePedaleK));
            this.Kinderfahrrad = new Item(ItemId.Kinderfahrrad, new List<Part>(parts));
            this.Items.Add(this.Kinderfahrrad);
			
		//Damenfahrrad
			parts.Clear(); // Liste leeren
            parts.Add(new Part(1, this.KetteD)); //item hinzufügen
			parts.Add(new Part(1, this.Mutter38));
			parts.Add(new Part(1, this.Schraube38));
			parts.Add(new Part(1, this.PedalCpl));
			parts.Add(new Part(1, this.FahrradOhnePedaleD));
            this.Damenfahrrad = new Item(ItemId.Damenfahrrad, new List<Part>(parts));
            this.Items.Add(this.Damenfahrrad);

        //Herrenfahrrad
            parts.Clear(); // Liste leeren
            parts.Add(new Part(1, this.KetteH)); //item hinzufügen
			parts.Add(new Part(1, this.Mutter38));
			parts.Add(new Part(1, this.Schraube38));
			parts.Add(new Part(1, this.PedalCpl));
			parts.Add(new Part(1, this.FahrradOhnePedaleH));
            this.Herrenfahrrad = new Item(ItemId.Herrenfahrrad, new List<Part>(parts));
            this.Items.Add(this.Herrenfahrrad);
           

        #endregion
        }
    }
}
