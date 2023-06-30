using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._3
{
    internal class Program
    {
        static void Main()
        {
            int size = 5;
            double[] array = GenerateRandomNumbersArray(size); 
            Console.WriteLine("Массив чисел:");
            PrintArray(array);

            double difference = CalculateDifference(array);

            Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference.ToString("F2"));

            Console.ReadLine();
        }
        static double[] GenerateRandomNumbersArray(int size)
        {
            Random random = new Random();
            double[] array = new double[size];

            for (int i = 0; i < size; i++)
            {
                double randomNumber = random.NextDouble() * 100;
                array[i] = Math.Round(randomNumber, 2);
            }

            return array;
        }

        static double CalculateDifference(double[] array)
        {
            double max = array[0];
            double min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            double difference = max - min;
            return difference;
        }
        static void PrintArray(double[] array)
        {
            Console.Write("[");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString("F2")); 

                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
        }
    }
}
