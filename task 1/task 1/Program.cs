using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
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
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 4 || x > 10000) Console.WriteLine("0");
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
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.Write(mas[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine(count);
            }
            Console.ReadLine();
        }
    }
}
