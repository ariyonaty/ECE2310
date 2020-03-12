using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week0802
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            int size = 1;
            double startRange = 0, endRange = 0;
            getInput(ref startRange, txtA.Text);
            getInput(ref endRange, txtB.Text);
            getInput(ref size, txtN.Text);
            
            double[] randArray = new double[size];

            Random rand = new Random();
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = Math.Round((rand.NextDouble() * (endRange - startRange)) + startRange, 4);
            }

            displayArray(randArray);
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
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
            txtA.Clear();
            txtB.Clear();
            txtN.Clear();
            listBox1.Items.Clear();
        }

        private void displayArray(double[] array)
        {
            foreach (double i in array)
            {
                listBox1.Items.Add(i);
            }
        }

        private void getInput(ref double x, string text)
        {
            if (!Double.TryParse(text, out x))
            {
                MessageBox.Show("Error, input must be a number.", "Input Validation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
            }
        }

        private void getInput(ref int x, string text)
        {
            if (!Int32.TryParse(text, out x) && x < 0)
            {
                MessageBox.Show("Error, size must be positive number.", "Input Validation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }
            return;
        }
    }
}
