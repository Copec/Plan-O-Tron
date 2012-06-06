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
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
        }

        private void CalculateForm_Load(object sender, EventArgs e)
        {

        }

        private void CaclulateButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
            string path = saveFileDialog1.FileName;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    
    }
}
