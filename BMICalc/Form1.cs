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
            double weight = Convert.ToDouble(txtPounds.Text);
            double feet = Convert.ToDouble(txtFeet.Text);
            double inches = Convert.ToDouble(txtInches.Text);

            double height = feet * 12 + inches;
            double bmi = (weight * 703) / (height * height);

            textBox4.Text = Convert.ToString(Math.Round(bmi, 1));
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
        }
    }
}
