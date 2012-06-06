using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Plan_o_Tron_6000.UI
{
    /// <summary>
    /// Teilelsite zur Prüfung ob alle ItemList Daten Korrekt sind
    /// </summary>
    public partial class DebugWindow : Form
    {
        private Form1 window;

        public DebugWindow(Form1 window)
        {
            InitializeComponent();
            this.window = window;
            
        }

        private void StockButton_Click(object sender, EventArgs e)
        {
            if (window.Stock != null)
            {
                dataGridView1.DataSource = window.Stock;
            }
            else
            {
                MessageBox.Show("Keine Warenliste geladen. Wurde schon importiert?", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemListButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.List.Items;
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Width = 500;
        }

        private void WorkstationButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.Jobs.Workstations;
        }

        private void JobInspectorButton_Click(object sender, EventArgs e)
        {
            JobInspector ji = new JobInspector();
            ji.Show();
        }
    }
}
