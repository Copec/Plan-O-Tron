using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Plan_o_Tron_6000.Domain;
using Plan_o_Tron_6000.Statics;
using Plan_o_Tron_6000.XML;

namespace Plan_o_Tron_6000.UI
{
    public partial class Form1 : Form
    {
        private KonamiSequence sequence;
       
        public Form1()
        {
            InitializeComponent(); 
            this.sequence = new KonamiSequence();

        }

        public List<WarehouseItem> Stock
        {
            get
            {
                if(Program.WarehouseStock != null)
                    return Program.WarehouseStock.Stock;
                return null;
            }
        }

        private void Debug_Click(object sender, EventArgs e)
        {
            DebugWindow bugger = new DebugWindow(this);
            bugger.Show();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.der-postillon.com/2012/01/gastkommentar-fahrradfahrer-ihr-werdet.html"); 
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
                if (this.sequence.IsCompletedBy(e.KeyCode))
                {
                    this.DebugButton.Visible = true;
                    this.pictureBox1.Visible = true;
                    this.label1.Visible = true;
                    this.WizardButton.BackColor = Color.Red;
                    this.WizardButton.ForeColor = Color.Cyan;
                }
        }

        private void WizardButton_Click(object sender, EventArgs e)
        {
            CalculateForm wiz = new CalculateForm();
            wiz.Show();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            string path = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                try
                {
                    ImportXML.Import(path);
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ausnahmefehler", MessageBoxButtons.OK);
                }
            }
        }
    }
}
