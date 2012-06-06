using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Plan_o_Tron_6000.Statics;
using Plan_o_Tron_6000.UI;
using Plan_o_Tron_6000.Domain;

namespace Plan_o_Tron_6000
{
    static class Program
    {
        public static ItemList List = new ItemList();
        public static JobList Jobs = new JobList();
        public static Warehouse WarehouseStock;
        public static Orders  Orders = new Orders();
        public static WaitingLists WaitingLists = new WaitingLists();
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {    
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
