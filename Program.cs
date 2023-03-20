using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Найти средний рост студентов.
            double[] heights = { 170.2, 175.5, 168.9, 182.1, 177.6 };
            int n = heights.Length;
            double averageHeight = 0;
            for (int i = 0; i < n; i++)
            {
                averageHeight += heights[i];
            }
            averageHeight /= n;
            Console.WriteLine("Средний рост студентов: " + averageHeight);
            Console.Read();
        }
    }
}
