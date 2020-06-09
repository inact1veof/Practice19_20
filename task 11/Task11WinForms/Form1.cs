using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task11WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputStr_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputStr_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 50) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonEncoding_Click(object sender, EventArgs e)
        {
            string InputString = InputStr.Text;
            string result = Encoding(InputString);
            resultEncoding.Items.Clear();
            resultEncoding.Items.Add(result);
            buttonDecoding.Enabled = true;
        }
        static string Encoding(string InputStr)
        {
            char[] InputMas = new char[InputStr.Length];
            InputMas = InputStr.ToCharArray();
            char[] ResultMas = new char[InputStr.Length];
            ResultMas[0] = InputMas[0];
            for (int i = 1; i < InputMas.Length; i++)
            {
                if (InputMas[i] == InputMas[i - 1]) ResultMas[i] = '1';
                else ResultMas[i] = '0';
            }
            return String.Join("", ResultMas);
        }
        static string Decoding(string InputStr)
        {
            char[] InputMas = new char[InputStr.Length];
            InputMas = InputStr.ToCharArray();
            char[] ResultMas = new char[InputStr.Length];
            ResultMas[0] = InputMas[0];
            for (int i = 1; i < InputMas.Length; i++)
            {
                if (InputMas[i] == InputMas[i - 1])
                {
                    if (InputMas[i] != ResultMas[i - 1]) ResultMas[i] = '0';
                    else ResultMas[i] = '1';
                }
                else
                {
                    if (InputMas[i] == ResultMas[i - 1]) ResultMas[i] = '1';
                    else ResultMas[i] = '0';
                }
            }
            return String.Join("", ResultMas);
        }

        private void buttonDecoding_Click(object sender, EventArgs e)
        {
            string InputString = resultEncoding.Items[0].ToString();
            string result = Decoding(InputString);
            resultDecoding.Items.Clear();
            resultDecoding.Items.Add(result);
        }
    }
}
