using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECE2310_HW02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (!double.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Error. Input 1 must be a number!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            if (!double.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Error. Input 2 must be a number!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            txtOut.Text = Convert.ToString(num1 + num2);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (!double.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Error. Input 1 must be a number!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            if (!double.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Error. Input 2 must be a number!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            txtOut.Text = Convert.ToString(num1 - num2);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (!double.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Error. Input 1 must be a number!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            if (!double.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Error. Input 2 must be a number!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            txtOut.Text = Convert.ToString(num1 * num2);
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (!double.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Error. Input 1 must be a number!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            if (!double.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Error. Input 2 must be a number!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            txtOut.Text = Convert.ToString((num1 + num2) / 2);
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
            txtNum1.Clear();
            txtNum2.Clear();
            txtOut.Clear();
        }
    }
}
