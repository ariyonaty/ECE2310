using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECE2310_HW04_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int n;
            int i = 1, factorial = 1;
            double eVal = 1.0;

            if (!Int32.TryParse(txtN.Text, out n) || n < 0)
            {
                MessageBox.Show("Error, input must be positive number!", "Input Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            lstFactorial.Items.Clear();

            if (n == 0 || n == 1)
            {
                lstFactorial.Items.Add($"{n}! = {factorial:n0}");
                return;
            }

            while (i <= n)
            {
                factorial *= i;
                lstFactorial.Items.Add($"{i}! = {factorial:n0}");
                eVal += (double)(1.0 / factorial);
                i++;
            }
            lstFactorial.Items.Add($"e approximation: {Math.Round(eVal, 6)}");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearForm()
        {
            txtN.Clear();
            lstFactorial.Items.Clear();
        }
    }
}
