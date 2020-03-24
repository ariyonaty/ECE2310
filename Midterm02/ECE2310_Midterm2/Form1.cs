/*
 Ari Yonaty
 ECE 2310
 3.24.2020
 Midterm 2
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECE2310_Midterm2
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

        private void btnSep_Click(object sender, EventArgs e)
        {
            int n;

            if (!Int32.TryParse(txtInput.Text, out n) || n < 0)
            {
                MessageBox.Show("Error, input must be positive number.", "Input Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearForm();
                return;
            }

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                seperate(rand.Next(0, 100000));
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

        private void seperate(int num)
        {
            int n1 = (num % 100000) / 10000;
            int n2 = (num % 10000) / 1000;
            int n3 = (num % 1000) / 100;
            int n4 = (num % 100) / 10;
            int n5 = (num % 10);

            int sum = n1 + n2 + n3 + n4 + n5;
            listBox1.Items.Add($"{num} --> {n1} + {n2} + {n3} + {n4} + {n5} = {sum}");
        }

        private void clearForm()
        {
            listBox1.Items.Clear();
            txtInput.Clear();
        }
    }
}
