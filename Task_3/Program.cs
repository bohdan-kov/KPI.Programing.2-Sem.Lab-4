using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Task_3
    {
        static void Main(string[] args)
        {
            int[] number_1 = { 3, 4, 2, 1, 7 };
            int[] number_2 = { 6, 2, 1, 8, 9, 5 };
            int[] numbers_3 = { 3, 5, 8, 7, 2 };
            PrintResult(number_1);
            PrintResult(number_2);
            PrintResult(numbers_3);
            
        }

        public static int[] ResultCal(int[] array)
        {
            int[] resultArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    resultArray[i] = array[i] * (-1);
                else if (array[i] > 0)
                    resultArray[i] = array[i] - 3;
                else
                    resultArray[i] = -2;
            }

            return resultArray;
        }

        static void PrintResult(int[] numbers)
        {
            int[] resultArray;
            try
            {
                resultArray = ResultCal(numbers);
                Console.WriteLine("\nData: ");
                foreach (int elem in numbers)
                {
                    Console.Write($"{elem} ");
                }
                Console.WriteLine("\nResult:");
                foreach (int elem in resultArray)
                {
                    Console.Write($"{elem} ");
                }
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
