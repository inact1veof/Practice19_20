using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace task_6
{
    class Program
    {
        public static double[] PoslOne = null;
        public static double[] PoslTwo = null;
        public static double a1 = 0;
        public static double a2 = 0;
        public static double a3 = 0;
        public static int n = 0;
        public static int m = 0;
        public static int l = 0;
        public static int count = 0;
        public static bool check = false;
        public static int chet = 0;
        static double InputNumberDouble()
        {
            double result = 0;
            bool ok = false;
            do
            {
                ok = double.TryParse(Console.ReadLine(), out result);
                if (!ok)
                {
                    Console.Write("Некорректный ввод, попробуйте еще: ");
                }
            } while (!ok);
            return result;
        }
        static int InputNumberInt()
        {
            int result = 0;
            bool ok = false;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out result);
                if (!ok || result <= 0)
                {
                    Console.Write("Некорректный ввод, попробуйте еще: ");
                }
            } while (!ok);
            return result;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Данная программа работает с последовательностями");
            Console.ResetColor();
            Console.Write("Введите a1: ");
            a1 = InputNumberDouble();
            Console.WriteLine();
            Console.Write("Введите a2: ");
            a2 = InputNumberDouble();
            Console.WriteLine();
            Console.Write("Введите a2: ");
            a3 = InputNumberDouble();
            Console.WriteLine();
            Console.Write("Введите N: ");
            n = InputNumberInt();
            Console.WriteLine();
            Console.Write("Введите L: ");
            l = InputNumberInt();
            Console.WriteLine();
            Console.Write("Введите M: ");
            m = InputNumberInt();
            Console.WriteLine();
            MakePoslAsync(n);
            MakePoslAfterL(l, m);
            Console.ReadLine();
        }
        static double MakePosl(int n)
        {
            if (n == 1)
            {
                count++;
                return a1;
            }
            else if (n == 2)
            {
                count++;
                return a2;
            }
            else if (n == 3)
            {
                count++;
                return a3;
            }
            else if (n > 3)
            {
                count++;
                return (((7/3)*MakePosl(n-1)+MakePosl(n-2))/2)* MakePosl(n-3);
            }
            else return 10;

        }
        static async void MakePoslAfterL(int l, int m)
        {
            PoslTwo = new double[l+m];
            for (int i = l-1; i < l+m; i++)
            {
                PoslTwo[i] = await Task.Run(() => MakePosl(i + 1));
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Программа остановлена, составлена последовательность l..l+m");
            Console.ResetColor();
            for (int i = l-1; i < l + m; i++)
            {
                Console.Write(PoslTwo[i] + " ");
            }
            double sum = 0;
            for (int i = l - 1; i < l + m; i++)
            {
                sum += PoslTwo[i];
            }
            Console.WriteLine();
            Console.WriteLine("Сумма элементов последовательности = {0} (доп.функция)", sum);
            Console.ReadKey();
        }
        static async void MakePoslAsync(int n)
        {
            PoslOne = new double[n];
            for (int i = 0; i < n; i++)
            {
                PoslOne[i] = await Task.Run(() => MakePosl(i+1));
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Программа остановлена, составлена последовательность 1..n");
            Console.ResetColor();
            for (int i = 0; i < n; i++)
            {
                Console.Write(PoslOne[i] + " ");
            }
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += PoslOne[i];
            }
            Console.WriteLine();
            Console.WriteLine("Сумма элементов последовательности = {0} (доп.функция)", sum);
        }
    }
}
