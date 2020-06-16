using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace task_2
{
    public partial class Form1 : Form
    {
        public static int n = 0;
        public static int result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void UserChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserChoice.SelectedIndex == 0)
            {
                ButtonInputFile.Visible = true;
                label2.Visible = false;
                InputUserNumber.Visible = false;
            }
            if (UserChoice.SelectedIndex == 1)
            {
                label2.Visible = true;
                InputUserNumber.Visible = true;
                ButtonInputFile.Visible = false;
            }
        }

        private void InputUserNumber_TextChanged(object sender, EventArgs e)
        {
            if (InputUserNumber.Text != "") buttonStart.Enabled = true;
            else buttonStart.Enabled = false;
        }

        private void ButtonInputFile_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Данные |*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ButtonInputFile.Enabled = false;
                buttonStart.Enabled = true;
                bool ok = false;
                ok = int.TryParse(File.ReadAllText(ofd.FileName), out n);
                if (!ok)
                {
                    labelError.Visible = true;
                    buttonStart.Enabled = false;
                    ButtonInputFile.Enabled = true;
                }
                else buttonStart.Enabled = true;
            }
            else
            {
                buttonStart.Enabled = false;
            }
        }

        private void InputUserNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            bool ok = true;
            ButtonInputFile.Enabled = true;
            if (UserChoice.SelectedIndex == 1)
            {
                ok = int.TryParse(InputUserNumber.Text, out n);
                if (ok == false) labelError.Visible = true;
                else
                {
                    labelError.Visible = false;
                    if (n != 0)
                    {
                        result = SearchItem(n);
                        OutResult.Text = result.ToString();
                        ButtonSaveFile.Enabled = true;
                    }
                    else
                    {
                        labelError.Visible = true;
                    }
                }
            }
            else
            {
                if (n != 0)
                {
                    result = SearchItem(n);
                    OutResult.Text = result.ToString();
                    ButtonSaveFile.Enabled = true;
                }
                else
                {
                    labelError.Visible = true;
                }
            }

        }
        static int Increment(int x)
        {
            if (x == 2)
            {
                return 0;
            }
            else
            {
                return x + 1;
            }
        }
        static int SearchItem(int n)
        {
            if (n == 1) return 0;
            int level = (int)(Math.Log(n, 2) + 0.9999);
            uint length = (uint)Math.Pow(2, level);
            return Increment(SearchItem((int)(n - length / 2)));
        }
        private void ButtonSaveFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(fbd.SelectedPath+ "\\output.txt", result.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
