using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12
{
    class Program
    {
        static int[] InsertSort(int[] InputMas, ref int CountMails, ref int CountCompares)
        {
            int[] result = new int[InputMas.Length];
            for (int i = 0; i < InputMas.Length; i++)
            {
                int j = i;
                CountCompares++;
                while (j > 0 && result[j - 1] > InputMas[i])
                {
                    result[j] = result[j - 1];
                    j--;
                    CountMails++;
                }
                result[j] = InputMas[i];
            }
            return result;
        }
        static int[] CountingSort(int[] InputMas, ref int CountMails1, ref int CountCompares1)
        {
            int max = InputMas.Max();
            int min = InputMas.Min();
            int[] count = new int[max - min + 1];
            int z = 0;
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < InputMas.Length; i++)
            {
                count[InputMas[i] - min]++;
            }

            for (int i = min; i <= max; i++)
            {
                while (count[i - min]-- > 0)
                {
                    CountCompares1++;
                    InputMas[z] = i;
                    z++;
                }
            }
            CountMails1 = z;
            return InputMas;
        }
        static void SortMasRandom(int[] RandomMas)
        {
            int CountMails = 0;
            int CountCompares = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Отсортированный массив 1(метод простых вставок):");
            Console.ResetColor();
            int[] ResMas1 = InsertSort(RandomMas, ref CountMails, ref CountCompares);
            for (int i = 0; i < ResMas1.Length; i++)
            {
                Console.Write(ResMas1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Количество сравнений: {0}", CountCompares);
            Console.WriteLine("Количество пересылок: {0}", CountMails);
            int CountMails1 = 0;
            int CountCompares1 = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Отсортированный массив 1(метод подсчета):");
            Console.ResetColor();
            int[] ResMas2 = CountingSort(RandomMas, ref CountMails1, ref CountCompares1);
            for (int i = 0; i < ResMas2.Length; i++)
            {
                Console.Write(ResMas2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Количество сравнений: {0}", CountCompares1);
            Console.WriteLine("Количество пересылок: {0}", CountMails1);
        }
        static void SortMasInc(int[] IncMas)
        {
            int CountMails = 0;
            int CountCompares = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Отсортированный массив 2(метод простых вставок):");
            Console.ResetColor();
            int[] ResMas1 = InsertSort(IncMas, ref CountMails, ref CountCompares);
            for (int i = 0; i < IncMas.Length; i++)
            {
                Console.Write(ResMas1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Количество сравнений: {0}", CountCompares);
            Console.WriteLine("Количество пересылок: {0}", CountMails);
            int CountMails1 = 0;
            int CountCompares1 = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Отсортированный массив 2(метод подсчета):");
            Console.ResetColor();
            int[] ResMas2 = CountingSort(IncMas, ref CountMails1, ref CountCompares1);
            for (int i = 0; i < ResMas2.Length; i++)
            {
                Console.Write(ResMas2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Количество сравнений: {0}", CountCompares1);
            Console.WriteLine("Количество пересылок: {0}", CountMails1);
        }
        static void SortMasDec(int[] DecMas)
        {
            int CountMails = 0;
            int CountCompares = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Отсортированный массив 3(метод простых вставок):");
            Console.ResetColor();
            int[] ResMas1 = InsertSort(DecMas, ref CountMails, ref CountCompares);
            for (int i = 0; i < DecMas.Length; i++)
            {
                Console.Write(ResMas1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Количество сравнений: {0}", CountCompares);
            Console.WriteLine("Количество пересылок: {0}", CountMails);
            int CountMails1 = 0;
            int CountCompares1 = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Отсортированный массив 3(метод подсчета):");
            Console.ResetColor();
            int[] ResMas2 = CountingSort(DecMas, ref CountMails1, ref CountCompares1);
            for (int i = 0; i < ResMas2.Length; i++)
            {
                Console.Write(ResMas2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Количество сравнений: {0}", CountCompares1);
            Console.WriteLine("Количество пересылок: {0}", CountMails1);
        }
        static int InputNumber()
        {
            bool ok = false;
            int result = 0;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out result);
                if (!ok)
                {
                    Console.Write("Некорректный ввод, попробуйте еше раз: ");
                }
                if (result > 20000000)
                {
                    Console.Write("Некорректный ввод, попробуйте еше раз: ");
                    ok = false;
                }
            } while (!ok);
            return result;
        }
        static void UseFunction(int n)
        {
            int[] FirstMas = new int[n];
            int[] SecondMas = new int[n];
            int[] ThirdMas = new int[n];
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Каким образом сформировать массив?");
            Console.ResetColor();
            Console.WriteLine("1. Вручную");
            Console.WriteLine("2. С помощью ДСЧ");
            int choice = 0;
            do
            {
                choice = InputNumber();
                if (choice < 1 || choice > 2)
                {
                    Console.Write("Такого варианта нет, попробуйте еще раз: ");
                }
            } while (choice <= 0);
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Вы выбрали вариант заполнения вручную");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Введите элемент номер {0}: ", i + 1);
                            FirstMas[i] = InputNumber();
                        }
                        Console.WriteLine("Массив заполнен, для дальнейшей работы массив клонируется 2 раза и сортируется в разном порядке");
                        SecondMas = (int[])FirstMas.Clone();
                        Array.Sort(SecondMas);
                        ThirdMas = (int[])SecondMas.Clone();
                        Array.Reverse(ThirdMas);
                        Console.WriteLine("Исходные массивы");
                        Console.ResetColor();
                        for (int i = 0; i < FirstMas.Length; i++)
                        {
                            Console.Write(FirstMas[i] + " ");
                        }
                        Console.WriteLine();
                        for (int i = 0; i < SecondMas.Length; i++)
                        {
                            Console.Write(SecondMas[i] + " ");
                        }
                        Console.WriteLine();
                        for (int i = 0; i < ThirdMas.Length; i++)
                        {
                            Console.Write(ThirdMas[i] + " ");
                        }
                        Console.WriteLine();
                        SortMasRandom(FirstMas);
                        SortMasInc(SecondMas);
                        SortMasDec(ThirdMas);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Вы выбрали вариант заполнения с помощью ДСЧ");
                        Random rnd = new Random();
                        for (int i = 0; i < FirstMas.Length; i++)
                        {
                            FirstMas[i] = rnd.Next(-100, 100);
                        }
                        SecondMas = (int[])FirstMas.Clone();
                        Array.Sort(SecondMas);
                        ThirdMas = (int[])SecondMas.Clone();
                        Array.Reverse(ThirdMas);
                        Console.WriteLine("Исходные массивы");
                        Console.ResetColor();
                        for (int i = 0; i < FirstMas.Length; i++)
                        {
                            Console.Write(FirstMas[i] + " ");
                        }
                        Console.WriteLine();
                        for (int i = 0; i < SecondMas.Length; i++)
                        {
                            Console.Write(SecondMas[i] + " ");
                        }
                        Console.WriteLine();
                        for (int i = 0; i < ThirdMas.Length; i++)
                        {
                            Console.Write(ThirdMas[i] + " ");
                        }
                        Console.WriteLine();
                        SortMasRandom(FirstMas);
                        SortMasInc(SecondMas);
                        SortMasDec(ThirdMas);
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {
            int n = -1;
            do
            {
                //====================Main=====================
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Для выхода введите 0");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Введите число элементов в массиве: ");
                Console.ResetColor();
                do
                {
                    n = InputNumber();
                    if (n < 0)
                    {
                        Console.Write("Число элементов должно быть больше нуля, попробуйте еще: ");
                    }
                    if (n == 0) Environment.Exit(0);
                } while (n <= 0);
                UseFunction(n);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Для продолжения нажмите любую кнопку");
                Console.ResetColor();
                Console.ReadKey();
            } while (n != 0);      
        }
    }
}
