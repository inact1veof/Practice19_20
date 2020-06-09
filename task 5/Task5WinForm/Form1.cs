using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5WinForm
{
    public partial class MainForm : Form
    {
        public static double Res = 0;
        public static double[,] matr = null;
        static void RandomReslise()
        {
            Random rnd = new Random();
            int n = rnd.Next(2, 5);
            matr = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i, j] = rnd.Next(-100, 100) + rnd.NextDouble();
                    matr[i, j] = Math.Round(matr[i, j], 1);
                }
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (i < n / 2)
                {
                    for (int j = i; j < n - i; j++)
                    {
                        count++;
                    }
                }
                else
                {
                    for (int j = n - 1 - i; j <= i; j++)
                    {
                        count++;
                    }
                }
            }
            double[] mas = new double[count];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (i < n / 2)
                {
                    for (int j = i; j < n - i; j++)
                    {
                        mas[index] = matr[i, j];
                        index++;
                    }
                }
                else
                {
                    for (int j = n - 1 - i; j <= i; j++)
                    {
                        mas[index] = matr[i, j];
                        index++;
                    }
                }
            }
            Array.Sort(mas);
            Res = mas[count - 1];
            Res = Math.Round(Res, 1);
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
                label3.Visible = true;
                listBox1.Visible = true;
                RandomReslise();
                listBox1.Items.Clear();
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    double[] tmpMas = new double[matr.GetLength(1)];
                    for (int j = 0; j < matr.GetLength(1); j++)
                    {
                        tmpMas[j] = matr[i, j];
                    }
                    string print = String.Join(" ", tmpMas);
                    listBox1.Items.Add(print);
                }
                labelResult.Text = $"Ответ: {Res}";
        }
    }
}
