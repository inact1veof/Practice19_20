using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace task_8
{
    public class logicClass
    {
        public static bool CheckComm(double[,] mas)
        {
            List<string> namesPoints = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            bool ok = false;
            int count = 0;
            List<string> CheckedPoints = new List<string>();
            CheckedPoints.Add($"{namesPoints[count]}");
            count++;
            Stack<string> MbPoints = new Stack<string>();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                if (mas[i, 0] == 1)
                {
                    MbPoints.Push($"{namesPoints[i]}");
                    count++;
                }
            }
            string temp = null;
            int ind = 0;
            while (MbPoints.Count != 0)
            {
                if (MbPoints.Count == 0) break;
                else temp = MbPoints.Pop();
                if (CheckedPoints.Contains(temp) != true)
                {
                    CheckedPoints.Add(temp);
                    ind = namesPoints.IndexOf(temp);
                    for (int i = 0; i < mas.GetLength(0); i++)
                    {
                        if (mas[i, ind] == 1)
                        {
                            MbPoints.Push($"{namesPoints[i]}");
                            count++;
                        }
                    }

                }
            }
            if (CheckedPoints.Count == mas.GetLength(0)) ok = true;
            else ok = false;
            return ok;
        }
        public static List<string> SeacrhPointLinked(double[,] mas)
        {
            string[] namesPoints = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            List<string> Points = new List<string>();
            double[,] newMas = null;
            bool ok = false;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                newMas = Del(mas, i);
                ok = CheckComm(newMas);
                if (ok == false) Points.Add($"Точка {namesPoints[i]}");
            }
            return Points;
        }
        static double[,] Del(double[,] mas, int index)
        {
            double[,] result = new double[mas.GetLength(0) - 1, mas.GetLength(1) - 1];
            int i1;
            int j1;
            for (int i = 0; i < result.GetLength(0); i++)
            {
                if (i >= index)
                {
                    i1 = i + 1;
                }
                else
                {
                    i1 = i;
                }
                for (int j = 0; j < result.GetLength(0); j++)
                {
                    if (j >= index)
                    {
                        j1 = j + 1;
                    }
                    else
                    {
                        j1 = j;
                    }
                    result[i, j] = mas[i1, j1];
                }
            }
            return result;
        }
    }
}
