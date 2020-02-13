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
                txtSales.Text = Convert.ToString("$" + Math.Round(input, 2));
                txtProfitRatio.Text = "3.0%";
                txtProfit.Text = Convert.ToString("$" + Math.Round(0.03 * input, 2));
            }
            else if (input > 1000 && input <= 5000)
            {
                txtSales.Text = Convert.ToString("$" + Math.Round(input, 2));
                txtProfitRatio.Text = "3.5%";
                txtProfit.Text = Convert.ToString("$" + Math.Round(0.035 * input, 2));
            }
            else if (input > 5000 && input <= 10000)
            {
                txtSales.Text = Convert.ToString("$" + Math.Round(input, 2));
                txtProfitRatio.Text = "4%";
                txtProfit.Text = Convert.ToString("$" + Math.Round(0.04 * input, 2));
            }
            else
            {
                txtSales.Text = Convert.ToString("$" + Math.Round(input, 2));
                txtProfitRatio.Text = "4.5%";
                txtProfit.Text = Convert.ToString("$" + Math.Round(0.045 * input, 2));
            }
        }

        private void clearForm()
        {
            txtInput.Clear();
            txtProfit.Clear();
            txtSales.Clear();
            txtProfitRatio.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
