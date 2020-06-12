using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputEps_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InputEps_KeyPress(object sender, KeyPressEventArgs e)
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
                if (InputEps.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }

        private void begLen_TextChanged(object sender, EventArgs e)
        {

        }

        private void begLen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == 45)
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (InputEps.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }

        private void endLen_TextChanged(object sender, EventArgs e)
        {
            if (InputEps.Text != "" && begLen.Text != "" && endLen.Text != "")
            {
                buttonStart.Enabled = true;
            }
            else buttonStart.Enabled = false;
        }

        private void endLen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == 45)
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (InputEps.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            double eps = Convert.ToDouble(InputEps.Text);
            double mid = 0;
            double x1 = Convert.ToDouble(begLen.Text);
            double x0 = Convert.ToDouble(endLen.Text);
            double result = 0;
            double Fresult = 10;
            do
            {
                mid = (x1 + x0) / 2;
                if (Function(mid) * Function(x1) <= 0)
                {
                    x0 = mid;
                }
                else
                {
                    x1 = mid;
                }
                result = mid;
                Fresult = Function(mid);
            } while (Math.Abs(Fresult) > eps);
            labelResult.Text = result.ToString();
        }
        static double Function(double x)
        {
            double result = Math.Pow(x, 4) + 0.8 * Math.Pow(x, 3) - 0.4 * Math.Pow(x, 2) - 1.4 * x - 1.2;
            return result;
        }
    }
}
