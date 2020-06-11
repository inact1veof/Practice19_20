using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3
{
    public partial class Form1 : Form
    {
        public static double x = 0;
        public static double y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void InputX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || e.KeyChar == 8)
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (InputX.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }

        private void InputY_TextChanged(object sender, EventArgs e)
        {
            if (InputY.Text != "" && InputX.Text != "")
            {
                buttonStart.Enabled = true;
            }
            else buttonStart.Enabled = false;
        }

        private void InputY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || e.KeyChar == 8)
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (InputY.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }

        private void InputX_TextChanged(object sender, EventArgs e)
        {
            if (InputY.Text != "" && InputX.Text != "")
            {
                buttonStart.Enabled = true;
            }
            else buttonStart.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(InputX.Text);
            y = Convert.ToDouble(InputY.Text);
            bool ok = false;
            double result = 0;
            if (y >= 0 && x * x + y * y <= 4 && x * x + y * y >= 1) ok = true;
            else ok = false;
            if (ok) result = 0;
            else result = x;
            string res = $"u = {result}";
            label5.Text = res;
        }
    }
}
