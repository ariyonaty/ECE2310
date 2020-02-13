using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECE2310_HW03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnProfit_Click(object sender, EventArgs e)
        {
            double input;
            if(!Double.TryParse(txtInput.Text, out input) || input < 0)
            {
                MessageBox.Show("Error. Input must be a positive number!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            if (input >= 0 && input <= 1000)
            {
                calculate(input, 0.03);
            }
            else if (input > 1000 && input <= 5000)
            {
                calculate(input, 0.035);
            }
            else if (input > 5000 && input <= 10000)
            {
                calculate(input, 0.04);
            }
            else
            {
                calculate(input, 0.045);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearForm()
        {
            txtInput.Clear();
            txtProfit.Clear();
            txtSales.Clear();
            txtProfitRatio.Clear();
        }

        private void calculate(double input, double percent)
        {
            txtSales.Text = Convert.ToString("$" + Math.Round(input, 2));
            txtProfitRatio.Text = Convert.ToString(percent * 100 + "%");
            txtProfit.Text = Convert.ToString("$" + Math.Round(percent * input, 2));
        }
    }
}
