using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    public class Point
    {
        string name;
        string[] linkedPoints;
        public string Name { get; set; }
        public Point(string n, string[] linkP)
        {
            Name = n;
            linkedPoints = new string[linkP.Length];
            for (int i = 0; i < linkP.Length; i++)
            {
                linkedPoints[i] = linkP[i];
            }
        }
    }
}
