using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECE2310_HW05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            lstRand.Items.Clear();
            Random rand = new Random();
            int r60 = 0, r60to70 = 0, r70to80 = 0, r80to90 = 0, r90to100 = 0;
            for (int i = 0; i < 1000; i++)
            {
                double r = rand.NextDouble() * (100 - 40) + 40;
                lstRand.Items.Add(Math.Round(r, 1));
                checkRange(ref r60, ref r60to70, ref r70to80, ref r80to90, ref r90to100, r);
            }
            lstRand.Items.Add("");
            lstRand.Items.Add("Range                Count");
            lstRand.Items.Add("--------------------------------------");
            lstRand.Items.Add($"Below 60            {r60}");
            lstRand.Items.Add($"[60, 70)              {r60to70}");
            lstRand.Items.Add($"[70, 80)              {r70to80}");
            lstRand.Items.Add($"[80, 90)              {r80to90}");
            lstRand.Items.Add($"[90, 100)]           {r90to100}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstRand.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkRange(ref int r60, ref int r60to70, ref int r70to80, ref int r80to90, ref int r90to100, double r)
        {
            if (r >= 90)
            {
                r90to100++;
            }
            else if (r >= 80)
            {
                r80to90++;
            }
            else if (r >= 70)
            {
                r70to80++;
            }
            else if (r >= 60)
            {
                r60to70++;
            }
            else
            {
                r60++;
            }
        }
    }
}
