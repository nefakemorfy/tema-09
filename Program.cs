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
            //Определить количество отрицательных.
            int[] array = new int[15];
            Random random = new Random();
            int negativeCount = 0;
            int positiveCount = 0;
            int zeroCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 11);
                if (array[i] < 0)
                {
                    negativeCount++;
                }
                else if (array[i] > 0)
                {
                    positiveCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            Console.WriteLine("Отрицательное:" + negativeCount);
            Console.WriteLine("Положительное:" + positiveCount);
            Console.WriteLine("Нулевое:" + zeroCount);
            Console.Read();
        }
    }
}
