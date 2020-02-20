using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week0502
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double inBase;
            int power;

            if (!double.TryParse(txtBase.Text, out inBase) || inBase == 0)
            {
                MessageBox.Show("Error. Base must be a numeric value.", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            if (!Int32.TryParse(txtPower.Text, out power) || power <= 0)
            {
                MessageBox.Show("Error. Power must be a number greater than 0.", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            clearForm();

            double origBase = inBase;

            for (int i = 1; i < power; i++)
            {
                inBase *= origBase;
                lstPowers.Items.Add(inBase.ToString());
                
            }
            lstPowers.Items.Add($"{origBase} to the power of {power} is {inBase}");
        }

        private void clearForm()
        {
            txtBase.Clear();
            txtPower.Clear();
            lstPowers.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= lstPowers.Items.Count; i++)
            {
                if (Convert.ToDouble(lstPowers.Items[i].ToString()) > 10000)
                {
                    MessageBox.Show($"First base^power greater than 10000 is {i+1}", "Power Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
    }
}
