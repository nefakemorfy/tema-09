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
            //Определить общую массу груза.
            int[] weights = { 10, 20, 30, 40, 50 };
            int n = weights.Length;
            int totalWeight = 0;
            for (int i = 0; i < n; i++)
            {
                totalWeight += weights[i];
            }
            Console.WriteLine("Общая масса груза: " + totalWeight);
            Console.Read();
        }
    }
}
