using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Task_2
    {
        static void Main(string[] args)
        {
            double[] numbers = { 4, 3, 1, -8 };
            double[] numbers2 = { 5, -8, 7, 2 };
            double[] numbers3 = { 3, 1, 4, 9, 7 };
            PrintResult(numbers);
            PrintResult(numbers2);
            PrintResult(numbers3);
        }
        public static double AvergMinMax(double[] numbers)
        {
            double tempNum;


            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        tempNum = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = tempNum;

                    }
                        
                }
            }
            Console.WriteLine($"MaxElem {numbers[numbers.Length - 1]}, third {numbers[2]}");
            return ((numbers[numbers.Length - 1] + numbers[2]) / 2); 
        }
        static void PrintResult(double[] Array)
        {
            try
            {
                Console.WriteLine($"Result {AvergMinMax(Array)}\n");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
