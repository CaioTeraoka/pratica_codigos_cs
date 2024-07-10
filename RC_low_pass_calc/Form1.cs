using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC_low_pass_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ohm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            float frequency, resistor, capacitor;
            switch (ohm.Text) {
                case "Ω":
                    resistor = float.Parse(res.Text);
                    break;
                case "KΩ":
                    resistor = float.Parse(res.Text)*1000;
                    break;
                case "MΩ":
                    resistor = float.Parse(res.Text)*1000000;
                    break;
                default:
                    resistor = 0;
                    break;
            }
            switch (farad.Text)
            {
                case "F":
                    capacitor = float.Parse(cap.Text);
                    break;
                case "mF":
                    capacitor = float.Parse(cap.Text) * (1E-3f);
                    break;
                case "uF":
                    capacitor = float.Parse(cap.Text) * (1E-6f);
                    break;
                case "nF":
                    capacitor = float.Parse(cap.Text) * (1E-9f);
                    break;
                case "pF":
                    capacitor = float.Parse(cap.Text) * (1E-12f);
                    break;
                default:
                    capacitor = 0;
                    break;
            }
            frequency = 1 / (2 * 3.14159265f * resistor * capacitor);
            freq.Text = frequency.ToString();
            
        }//end calculate button

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }// end class
}// end namespace
