using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Plan_o_Tron_6000.Domain;
using Plan_o_Tron_6000.Statics;
using System.Diagnostics;

namespace Plan_o_Tron_6000.XML
{
    /// <summary>
    /// Lädt XML von SCSim.de in speicher. Erster Schritt im Assistent
    /// </summary>
    public static class ImportXML
    {
        public static void Import(string path = "output.xml")
        {
            XDocument data = XDocument.Load(path);

            int currentPeriod = Convert.ToInt32(data.Root.Attribute("period").Value) + 1;

            foreach (XElement element in data.Elements().Elements("warehousestock").Elements("article"))
            {
                var id = element.Attribute("id").Value + " ";
                Item temp = Program.List.Items.FirstOrDefault(x => ((int)x.Id) == Convert.ToInt32(id));

                if (temp != null)
                {
                    Program.WarehouseStock.Stock.Add(new WarehouseItem(
                        Convert.ToInt32(element.Attribute("amount").Value),
                        Convert.ToDouble(element.Attribute("price").Value),
                        temp));
                }
            }

            foreach (XElement element in data.Elements().Elements("futureinwardstockmovement").Elements())
            {
                var article = element.Attribute("article").Value + " ";
                int mode = Convert.ToInt32(element.Attribute("mode").Value);
                Item temp = Program.List.Items.FirstOrDefault(x => ((int)x.Id) == Convert.ToInt32(article));
                int orderPeriod = Convert.ToInt32(element.Attribute("orderperiod").Value);

                bool expressOrder = (mode == 4);


                if (temp != null)
                {
                    Program.Orders.Future.Add(new Order(expressOrder, orderPeriod, temp, Convert.ToInt32(element.Attribute("amount").Value)));
                }
            }


            foreach (XElement element in data.Elements().Elements("waitinglistworkstations").Elements())
            {
                //                                int workplaceId = Convert.ToInt32(element.Attribute("id").Value);
                //                                WaitingListJob waitingListJob = new WaitingListJob();
                //                                //TODO: Leere Objekte anlegen oder nicht?
                //                                    Program.WaitingLists.Jobs.FirstOrDefault(x => x.Equals(workplaceId));

                //                                if (waitingListJob != null)
                //                                {
                //                                    waitingListJob.TimeNeeded += Convert.ToInt32(element.Attribute("timeneed").Value);
                //                                }
                foreach (XElement child in element.Elements())
                {
                    //                                    var id = child.Attribute("item").Value + " ";
                    //                                    Teil teil = teilList.FirstOrDefault(x => x.Bezeichung.StartsWith(id));

                    //                                    if (teil != null)
                    //                                    {
                    //                                        teil.MengeInBestellung += Convert.ToInt32(child.Attribute("amount").Value);
                    //                                    }
                }
            }

            foreach (XElement elementMissingPart in data.Elements().Elements("waitingliststock").Elements())
            {
                //                //Int32 itemID;
                //                var missingTeilId = elementMissingPart.Attribute("id").Value + " ";
                //                Teil missingTeil = teilList.FirstOrDefault(x => x.Bezeichung.StartsWith(missingTeilId));

                //                var summeMissingTeil = 0;

                foreach (XElement elementWaitingList in elementMissingPart.Elements())
                {
                    //                    var itemID = elementWaitingList.Attribute("item").Value + " ";

                    //                    Debug.WriteLine("MissingTeil: " + missingTeil.Bezeichung);
                    //                    Debug.WriteLine("Item: " + missingTeil.VerbautIn.FirstOrDefault(x => x.VerbautIn.Bezeichung.StartsWith(itemID)).VerbautIn.Bezeichung);
                    //                    Debug.WriteLine("Menge: " + missingTeil.VerbautIn.FirstOrDefault(x => x.VerbautIn.Bezeichung.StartsWith(itemID)).Menge);

                    //                    summeMissingTeil += missingTeil.VerbautIn.FirstOrDefault(x => x.VerbautIn.Bezeichung.StartsWith(itemID)).Menge * Convert.ToInt32(elementWaitingList.Attribute("amount").Value);

                    //                    Debug.WriteLine("SummeMissingTeil: " + summeMissingTeil);
                }

                //                Debug.WriteLine("GESAMT: SummeMissingTeil: " + summeMissingTeil);
                //                Debug.WriteLine("MissingTeil MengeInBestellungPeriode: " + missingTeil.MengeInBestellungPeriode);
                //                Debug.WriteLine(missingTeil.MengeInBestellungPeriode + " >= " + summeMissingTeil);

                //                if (missingTeil.MengeInBestellungPeriode >= summeMissingTeil)
                //                {
                //                    foreach (XElement elementWaitingList in elementMissingPart.Elements())
                //                    {
                //                        var itemID = elementWaitingList.Attribute("item").Value + " ";
                //                        Teil item = teilList.FirstOrDefault(x => x.Bezeichung.StartsWith(itemID));

                //                        Debug.WriteLine("Item MengeInBestellung: " + item.MengeInBestellung);
                //                        Debug.WriteLine("Amount waitingliststock: " + elementWaitingList.Attribute("amount").Value);

                //                        item.MengeInBestellung += Convert.ToInt32(elementWaitingList.Attribute("amount").Value);

                //                        // Zeit der offenen Aufträge, die in der kommenden Periode vorraussichtlich abgearbeitet werden, wird zu Arbeitsplatz.ZeitDruchWarteschlange hinzugefügt
                //                        for (int i = 0; i < item.Produktionszeit.Count; i++)
                //                        {
                //                            Debug.WriteLine("Arbeitsplatz ZeitDurchWarteschlange: " + item.Produktionszeit.ElementAt(i).Arbeitsplatz.ZeitDurchWarteschlange);
                //                            Debug.WriteLine("Fertigungszeit * Amount = " + item.Produktionszeit.ElementAt(i).Fertigungszeit + " * " + elementWaitingList.Attribute("amount").Value);
                //                            item.Produktionszeit.ElementAt(i).Arbeitsplatz.ZeitDurchWarteschlange += item.Produktionszeit.ElementAt(i).Fertigungszeit * Convert.ToInt32(elementWaitingList.Attribute("amount").Value);
                //                            Debug.WriteLine("Arbeitsplatz ZeitDurchWarteschlange: " + item.Produktionszeit.ElementAt(i).Arbeitsplatz.ZeitDurchWarteschlange);
                //                        }

                //                        Debug.WriteLine("Nach Addition: Item MengeInBestellung: " + item.MengeInBestellung);
                //                    }
                //}

                //                Debug.WriteLine(missingTeil.MengeInBestellungPeriode + " > 0 && " + missingTeil.MengeInBestellungPeriode + " < " + summeMissingTeil);

                //                if (missingTeil.MengeInBestellungPeriode > 0 && missingTeil.MengeInBestellungPeriode < summeMissingTeil)
                //                {
                //                    var mengeInBestellungOffen = Convert.ToDouble(missingTeil.MengeInBestellungPeriode);

                foreach (XElement elementWaitingList in elementMissingPart.Elements())
                {
                    //                        if (mengeInBestellungOffen > 0)
                    //                        {
                    //                            var itemID = elementWaitingList.Attribute("item").Value + " ";
                    //                            Teil item = teilList.FirstOrDefault(x => x.Bezeichung.StartsWith(itemID));

                    //                            Debug.WriteLine("Item MengeInBestellung: " + item.MengeInBestellung);
                    //                            Debug.WriteLine("Amount waitingliststock: " + elementWaitingList.Attribute("amount").Value);

                    //                            var tempExtraMengeInBestellung = (int)Math.Round(mengeInBestellungOffen / missingTeil.VerbautIn.FirstOrDefault(x => x.VerbautIn.Bezeichung.StartsWith(itemID)).Menge);
                    //                            item.MengeInBestellung += tempExtraMengeInBestellung;
                    //                            mengeInBestellungOffen -= tempExtraMengeInBestellung * missingTeil.VerbautIn.FirstOrDefault(x => x.VerbautIn.Bezeichung.StartsWith(itemID)).Menge;

                    //                            Debug.WriteLine("Nach Addition: Item MengeInBestellung: " + item.MengeInBestellung);

                    //                            // Zeit der offenen Aufträge, die in der kommenden Periode vorraussichtlich abgearbeitet werden, wird zu Arbeitsplatz.ZeitDruchWarteschlange hinzugefügt
                    //                            for (int i = 0; i < item.Produktionszeit.Count; i++)
                    //                            {
                    //                                Debug.WriteLine("Arbeitsplatz ZeitDurchWarteschlange: " + item.Produktionszeit.ElementAt(i).Arbeitsplatz.ZeitDurchWarteschlange);
                    //                                Debug.WriteLine("Fertigungszeit * Amount = " + item.Produktionszeit.ElementAt(i).Fertigungszeit + " * " + tempExtraMengeInBestellung);
                    //                                item.Produktionszeit.ElementAt(i).Arbeitsplatz.ZeitDurchWarteschlange += item.Produktionszeit.ElementAt(i).Fertigungszeit * tempExtraMengeInBestellung;
                    //                                Debug.WriteLine("Arbeitsplatz ZeitDurchWarteschlange: " + item.Produktionszeit.ElementAt(i).Arbeitsplatz.ZeitDurchWarteschlange);
                    //                            }
                    //                        }
                    //                    }
                    //                }

                }

                foreach (XElement element in data.Elements().Elements("ordersinwork").Elements())
                {
                    //                var id = element.Attribute("item").Value + " ";
                    //                Teil teil = teilList.FirstOrDefault(x => x.Bezeichung.StartsWith(id));
                    //                int workplaceId = Convert.ToInt32(element.Attribute("id").Value);
                    //                Arbeitsplatz arbeitsplatz = arbeitsplatzList.FirstOrDefault(x => x.Nummer.Equals(workplaceId));

                    //                if (teil != null)
                    //                {
                    //                    teil.MengeInBestellung += Convert.ToInt32(element.Attribute("amount").Value);
                    //                }
                    //                if (arbeitsplatz != null)
                    //                {
                    //                    arbeitsplatz.ZeitDurchWarteschlange += Convert.ToInt32(element.Attribute("timeneed").Value);
                    //                }


                }

                //                //            App.DataContext.SaveChanges();
                //return currentPeriod;
            }
        }
    }
}
