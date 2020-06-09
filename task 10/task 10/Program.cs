using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace task_10
{
    class Program
    {
        static int InputNumber()
        {
            bool ok = false;
            int result = 0;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out result);
                if (!ok)
                {
                    Console.Write("Некорректный ввод: попробуйте еще раз: ");
                }
                if (ok && result <= 0)
                {
                    Console.Write("Число должно быть больше нуля, попробуйте еще раз: ");
                    ok = false;
                }
            } while (!ok);
            return result;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Балансировка бинарного дерева при добавлении в него узла");
            Console.ResetColor();
            Console.Write("Введите значение верхнего узла: ");
            int n = InputNumber();
            IdealBalanceBinaryThree<int> three = new IdealBalanceBinaryThree<int>(n);
            Console.Write("Сколько элементов добавить в дерево: ");
            int q = InputNumber();
            for (int i = 0; i < q; i++)
            {
                three.Add(i);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Печать дерева:");
            Console.ResetColor();
            IdealBalanceBinaryThree<int>.ShowTree(three);
            Console.WriteLine("Количество элементов в дереве: {0}", three.Count);
            Console.WriteLine($"Количество элементов в правом поддереве: {three.SeachCountForRight(three)}");
            Console.WriteLine($"Количество элементов в правом поддереве: {three.SeachCountForLeft(three)}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Доп.функция - высота дерева равна: {0}", three.SearchHeight(three));
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
