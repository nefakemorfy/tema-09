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
            //Подсчитать количество четных элементов в одномерном массиве.
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int n = array.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество четных элементов: " + count);
            Console.Read();
        }
    }
}
