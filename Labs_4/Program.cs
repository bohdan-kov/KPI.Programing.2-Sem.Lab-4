using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_4
{
    internal class Task_1
    {
        static void Main(string[] args)
        {
            double[] numbers_1 = { 2, 1, 3, 6, 8 };
            PrintResult(numbers_1);
            double[] numbers_2 = {5, 1, 3, 7, 8};
            PrintResult(numbers_2);
            double[] numbers_3 = {2, 1, 4, 4, 3};
            PrintResult(numbers_3);
        }

        public static double sumMinMax(double[] numbers)
        {   
            double elemMin = numbers[0];
            double elemMax = numbers[0];

            foreach (double value in numbers) {
                elemMin = (elemMin < value) ? elemMin : value;
                elemMax = (elemMax > value) ? elemMax : value;
            }
            Console.WriteLine($"Min elem {elemMin}, Max elem {elemMax}");
            return (elemMin + elemMax);
        }

        static void PrintResult(double[] Array) 
        {
            Console.WriteLine("\nArray");
            foreach (double value in Array) Console.Write($"{value} ");
            Console.WriteLine("\nResult");
            try
            {
                Console.WriteLine(sumMinMax(Array));
            }
            catch (IndexOutOfRangeException e) 
            {
                Console.WriteLine("Exception!", e.Message);
            }
        }
    }
}
