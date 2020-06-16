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

namespace task_1
{
    public partial class Form1 : Form
    {
        public static int x = 0;
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
                ok = int.TryParse(File.ReadAllText(ofd.FileName), out x);
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
            if (UserChoice.SelectedIndex == 1)
            {
                ok = int.TryParse(InputUserNumber.Text, out x);              
            }
            if (ok == false)
            {
                labelError.Text = "Некорректный ввод";
                labelError.Visible = true;
            }
            else
            {
                labelError.Visible = false;
                if (x < 4 || x > 10000)
                {
                    OutResult.Text = "0";
                }
                else
                {
                    int count = 0;
                    List<int> res = new List<int>();
                    res = CreateSimpleMas(x);
                    int[] mas = new int[res.Count];
                    mas = res.ToArray();
                    for (int i = 0; i < mas.Length; i++)
                    {
                        for (int j = i; j < mas.Length; j++)
                        {
                            if (mas[i] + mas[j] == x) count++;
                        }
                    }
                    OutResult.Text = count.ToString();
                    result = count;
                }
                ButtonSaveFile.Enabled = true;
            }
        }
        private static bool isSimple(int n)
        {
            for (int i = 2; i <= (int)(n / 2); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static List<int> CreateSimpleMas(int n)
        {
            List<int> result = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (isSimple(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        private void ButtonSaveFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(fbd.SelectedPath+ "\\output.txt", result.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }
    }
}
