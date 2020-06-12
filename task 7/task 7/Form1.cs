using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputK_TextChanged(object sender, EventArgs e)
        {
            if (InputK.Text != "" && InputN.Text != "")
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void InputN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void InputK_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void InputN_TextChanged(object sender, EventArgs e)
        {
            if (InputK.Text != "" && InputN.Text != "")
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            labelResult.Text = "";
            int N = Convert.ToInt32(InputN.Text);
            int K = Convert.ToInt32(InputK.Text);
            if (N <= 10)
            {
                char[] masN = new char[N];
                char[] masK = new char[K];
                int j = (int)'A';
                for (int i = 0; i < N; i++)
                {
                    if (i <= 9) masN[i] = Char.Parse(i.ToString());
                    else
                    {
                        masN[i] = (char)j;
                        j++;
                    }
                }
                for (int i = 0; i < K; i++)
                {
                    masK[i] = '0';
                }
                addRes(masK);
                int k = K - 1;
                int min = 1;
                do
                {
                    for (int i = min; i < N; i++)
                    {
                        masK[k] = masN[i];
                        addRes(masK);
                    }
                    for (int i = 1; i <= k; i++)
                    {
                        if (masK[i] == masN[N - 1])
                        {
                            masK[i - 1] = masN[Index(masN, masK[i - 1]) + 1];
                            min = Index(masN, masK[i - 1]);
                            for (int l = i; l <= k; l++)
                                masK[l] = masN[min];
                            break;
                        }
                    }
                } while ((masK[0] != masN[N - 1]));
                if (K > 1) addRes(masK);
                double countRes = listBoxResult.Items.Count;
                labelResult.Text = countRes.ToString();
            }
            else
            {
                Form2 fr = new Form2();
                fr.ShowDialog();
            }
        }
        void addRes(char[] masK)
        {
            string s = "";
            for (int i = 0; i < masK.Length; i++)
            {
                s += masK[i] + " ";
            }
            listBoxResult.Items.Add(s);
        }
        static int Index(char[] masN, char x)
        {
            int i = 0;
            while (masN[i] != x)
            {
                i++;
            }
            return i;
        }       
    }
}
