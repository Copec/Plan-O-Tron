using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Plan_o_Tron_6000.Logic;

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
                
                // Werte von Decimal in int wandeln
                int h, d, k;

                h = Convert.ToInt32(numericUpDownH.Value);
                d = Convert.ToInt32(numericUpDownD.Value);
                k = Convert.ToInt32(numericUpDownK.Value);

                if (checkBox1.Checked)
                {
                    //Progrnosen
                    int[] p1 = new int[3];
                    p1[0] = Convert.ToInt32(numericUpDown7.Value);
                    p1[1] = Convert.ToInt32(numericUpDown4.Value);
                    p1[2] = Convert.ToInt32(numericUpDown5.Value);

                    int[] p2 = new int[3];
                    p2[0] = Convert.ToInt32(numericUpDown6.Value);
                    p2[1] = Convert.ToInt32(numericUpDown9.Value);
                    p2[2] = Convert.ToInt32(numericUpDown10.Value);

                    int[] p3 = new int[3];
                    p3[0] = Convert.ToInt32(numericUpDown12.Value);
                    p3[1] = Convert.ToInt32(numericUpDown8.Value);
                    p3[2] = Convert.ToInt32(numericUpDown11.Value);
                    

                    MainCalculation.Calc(h, d, k, p1, p2, p3);
                }
                else
                {
                    MainCalculation.Calc(h, d, k);
                }
            }
        }   
    }
}
