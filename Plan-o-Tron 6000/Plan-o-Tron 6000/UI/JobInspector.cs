using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Plan_o_Tron_6000.Statics;

namespace Plan_o_Tron_6000.UI
{
    public partial class JobInspector : Form
    {
        public JobInspector()
        {
            InitializeComponent();
            this.comboBox1.DataSource = Program.Jobs.Workstations;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Job> jobGrid = new List<Job>();
            Program.Jobs.JobsByStation.TryGetValue(((Workstation)this.comboBox1.SelectedValue), out jobGrid);
            this.dataGridView1.DataSource = jobGrid;
        }
    }
}
