using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week0701
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            clearForm();
            int[] a = new int[100];
            Random rand = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(1, 101);
                lstDisplay.Items.Add(a[i].ToString());
            }
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            int max = 0;
            int idx = 0;
            for (int i = 0; i < lstDisplay.Items.Count; i++)
            {
                if (max < Convert.ToInt32(lstDisplay.Items[i]))
                {
                    max = Convert.ToInt32(lstDisplay.Items[i]);
                    idx = i;
                }
            }
            MessageBox.Show($"Largest random number is {max} at index {idx}", "Maximum", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            int min = 100;
            int idx = 0;
            for (int i = 0; i < lstDisplay.Items.Count; i++)
            {
                if (min > Convert.ToInt32(lstDisplay.Items[i]))
                {
                    min = Convert.ToInt32(lstDisplay.Items[i]);
                    idx = i;
                }
            }
            MessageBox.Show($"Smallest random number is {min} at index {idx}", "Minimum", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            lstDisplay.Items.Clear();
        }
    }
}
