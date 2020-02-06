using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            restoreText();

            double feet, inches, weight;

            if (!double.TryParse(txtFeet.Text, out feet) || feet > 10 || feet < 0)
            {
                MessageBox.Show("Error! Feet must be a postive number and under 10 feet!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            if (!double.TryParse(txtInches.Text, out inches) || inches > 12 || inches < 0)
            {
                MessageBox.Show("Error! Inches must be a postive number and under 12 inches!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            if (!double.TryParse(txtPounds.Text, out weight) || weight < 0)
            {
                MessageBox.Show("Error! Weight must be a positive number!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            double height = feet * 12 + inches;
            double bmi = (weight * 703) / (height * height);

            textBox4.Text = Convert.ToString(Math.Round(bmi, 1));

            rangeCheck(bmi);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFeet.Clear();
            txtInches.Clear();
            txtPounds.Clear();
            textBox4.Clear();
            restoreText();
        }

        private void rangeCheck(double bmi)
        {
            if (bmi < 18.5)
            {
                underweight.Font = new Font(underweight.Font, FontStyle.Bold);
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                normal.Font = new Font(normal.Font, FontStyle.Bold);
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                overweight.Font = new Font(overweight.Font, FontStyle.Bold);
            }
            else
            {
                obese.Font = new Font(obese.Font, FontStyle.Bold);
            }
        }

        private void restoreText()
        {
            underweight.Font = new Font(underweight.Font, FontStyle.Regular);
            normal.Font = new Font(normal.Font, FontStyle.Regular);
            overweight.Font = new Font(overweight.Font, FontStyle.Regular);
            obese.Font = new Font(obese.Font, FontStyle.Regular);
        }

        private void clearForm()
        {
            txtFeet.Clear();
            txtInches.Clear();
            txtPounds.Clear();
            textBox4.Clear();
            restoreText();
        }
    }
}
