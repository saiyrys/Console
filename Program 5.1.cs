using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_1
{
    internal class Program
    {
        static void Main()
        {
            int[] array = GenerateRandomNumbersArray(4);

            Console.WriteLine("Массив чисел:");
            PrintArray(array);

            int evenCount = CountEvenNumbers(array);

            Console.WriteLine("Количество четных чисел в массиве: " + evenCount);

            Console.ReadLine();
        }
        static int[] GenerateRandomNumbersArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(100, 1000);
            }

            return array;
        }
        static int CountEvenNumbers(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (IsEven(array[i])) 
                {
                    count++;
                }
            }

            return count;
        }
        static bool IsEven(int number)
        {
            return number % 2 == 0;
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

