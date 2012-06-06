using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Plan_o_Tron_6000.XML
{
    /// <summary>
    /// Erstellt eine XML zum einspeisen in SCSim
    /// </summary>
    public static class ExportXML
    {
        public static bool export(string path, int[] sellWish, int planungsPeriode)
        {
            //            PPSEntities container = App.DataContext;
            //            var kTeilList = container.Teile.ToList<Teil>().OfType<KTeil>();
            //            var eTeilList = container.Teile.ToList<Teil>().OfType<ETeil>();
            //            var pTeilList = container.Teile.ToList<Teil>().OfType<PTeil>();
            //            var arbeitsplatzList = container.Arbeitsplätze.ToList<Arbeitsplatz>();

            //            XDeclaration fileXDeclaration = new XDeclaration("1.0", "utf-8", "yes");

            //            XElement userXElement = new XElement("user",
            //                                        new XAttribute("game", "1"),
            //                                        new XAttribute("group", "2"),
            //                                        new XAttribute("period", planungsPeriode)
            //                               );

            //            XElement qualitycontrolXElement = new XElement("qualitycontrol",
            //                                                new XAttribute("type", "no"),
            //                                                new XAttribute("losequantity", "0"),
            //                                                new XAttribute("delay", "0")
            //                                         );

            //             sellwish
            //            XElement sellwishItemList = new XElement("sellwish");
            //            for (int i = 1; i <= 3; i++)
            //            {
            //                var sellwishItemXElement = new XElement("item",
            //                                                        new XAttribute("article", i),
            //                                                        new XAttribute("quantity", sellWish[i - 1])
            //                                                        );
            //                sellwishItemList.Add(sellwishItemXElement);
            //            }

            //             selldirect
            //            XElement selldirectItemList = new XElement("selldirect");
            //            for (int i = 1; i <= 3; i++)
            //            {
            //                var selldirectItemXElement = new XElement("item",
            //                                                        new XAttribute("article", i),
            //                                                        new XAttribute("quantity", "0"),
            //                                                        new XAttribute("price", "0.0"),
            //                                                        new XAttribute("penalty", "0.0")
            //                                                        );
            //                selldirectItemList.Add(selldirectItemXElement);
            //            }

            //             orderlist
            //            XElement orderlistOrderList = new XElement("orderlist");

            //            foreach (KTeil kTeil in kTeilList)
            //            {
            //                if (kTeil.Eilbestellung != null && kTeil.Periodenbedarf > 0) // TODO:  Zum testen Ausgabe auch von 0. Hinzufügen: && kTeil.Periodenbedarf > 0
            //                {
            //                    int modus = 5;
            //                    if (kTeil.Eilbestellung == true)
            //                        modus = 4;

            //                    string cleanBez = Convert.ToString(kTeil.Bezeichung);
            //                    cleanBez = cleanBez.Substring(0, (cleanBez.Length - 2));
            //                    var orderXElement = new XElement("order",
            //                                            new XAttribute("article", cleanBez),
            //                                            new XAttribute("quantity", kTeil.Periodenbedarf),
            //                                            new XAttribute("modus", modus)
            //                                        );

            //                    orderlistOrderList.Add(orderXElement);
            //                }
            //            }

            //             productionlist
            //            XElement productionlistProductionList = new XElement("productionlist");

            //            List<int[]> productionList = BusinessLogic.ProductionPlanning.planeAuftragsreihenfolge();

            //            foreach (int[] production in productionList)
            //            {
            //                if (production != null && production[1] > 0) // TODO:  Zum testen Ausgabe auch von 0. Hinzufügen: && production[1] > 0
            //                {
            //                    var productionXElement = new XElement("production",
            //                                             new XAttribute("article", production[0]),
            //                                             new XAttribute("quantity", production[1])
            //                                        );

            //                    productionlistProductionList.Add(productionXElement);
            //                }
            //            }

            //             workingtimelist
            //            XElement workingtimelistWorkingtimeList = new XElement("workingtimelist");

            //            foreach (Arbeitsplatz arbeitsplatz in arbeitsplatzList)
            //            {
            //                if (arbeitsplatz.Schichten != null && arbeitsplatz.ÜberstundenInMin != null)
            //                {
            //                    var workingtimeXElement = new XElement("workingtime",
            //                                            new XAttribute("station", arbeitsplatz.Nummer),
            //                                            new XAttribute("shift", arbeitsplatz.Schichten),
            //                                            new XAttribute("overtime", arbeitsplatz.ÜberstundenInMin)
            //                                          );

            //                    workingtimelistWorkingtimeList.Add(workingtimeXElement);
            //                }
            //            }

            //             final input.xml
            //            XDocument data = new XDocument(
            //                fileXDeclaration,
            //                new XElement("input",
            //                    userXElement,
            //                    qualitycontrolXElement,
            //                    sellwishItemList,
            //                    selldirectItemList,
            //                    orderlistOrderList,
            //                    productionlistProductionList,
            //                    workingtimelistWorkingtimeList
            //                    )
            //            );

            //            if (data != null)
            //            {
            //                Debug.WriteLine("Pfad " + path);
            //                data.Save(path);
            //                return true;
            //            }
            //            else
            //            {
                            return false;
            //            };
            //        }
        }
    }
}
