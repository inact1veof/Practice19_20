using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_8
{
    public partial class Form1 : Form
    {
        public static double[,] mas = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void inputMatr_TextChanged(object sender, EventArgs e)
        {
            if (inputMatr.Text != String.Empty)
            {
                int m = inputMatr.Lines.Length;
                int n = inputMatr.Lines[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                bool ok = false;
                bool ok1 = false;
                for (int i = 1; i < m; i++)
                {
                    if (inputMatr.Lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length != inputMatr.Lines[i - 1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length || (inputMatr.Lines.Length != (inputMatr.Lines[0].Length / 2) + 1))
                    {
                        ok = false;
                        break;
                    }
                    else ok = true;
                }
                if (!ok) buttonOK.Enabled = false;
                else buttonOK.Enabled = true;
                //if (inputMatr.Lines.Length != (inputMatr.Lines[0].Length / 2) + 1)
                //{
                //    ok1 = false;
                //}
                //else ok1 = true;
                //if (!ok1) buttonOK.Enabled = false;
                //else buttonOK.Enabled = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void inputMatr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 50) && number != 8 && number != 32 && number != 13)
            {
                e.Handled = true;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int m = inputMatr.Lines.Length;
            int n = inputMatr.Lines[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            mas = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] s = inputMatr.Lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = Convert.ToDouble(s[j]);
                }
            }
            bool check = logicClass.CheckComm(mas);
            List<string> result = new List<string>();
            result = logicClass.SeacrhPointLinked(mas);
            listResult.Items.Clear();
            if (result.Count != 0)
            {
                foreach (string s in result)
                {
                    listResult.Items.Add(s);
                }
            }
            else
            {
                listResult.Items.Add("Точек сочленения нет");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
