using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._2
{
    internal class Program
    {
        static void Main()
        {
            int[] array = GenerateRandomNumbersArray(4);

            Console.WriteLine("Массив чисел:");
            PrintArray(array);

            int sum = CalculateSumOfOddPositionElements(array);

            Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);

            Console.ReadLine();
        }
        static int[] GenerateRandomNumbersArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-100, 100);
            }

            return array;
        }
        static int CalculateSumOfOddPositionElements(int[] array)
        {
            int sum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }
        static void PrintArray(int[] array)
        {
            Console.Write("[");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);

                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
        }
    }
}

