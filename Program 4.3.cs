using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_4._3
{
    internal class Program
    {
        static void Main()
        {
            int[] array = CreateArray(8);
            FillArray(array);

            Console.WriteLine("Массив:");
            PrintArray(array); 

            Console.ReadLine();
        }
        static int[] CreateArray(int size)
        {
            int[] array = new int[size];
            return array;
        }
        static void FillArray(int[] array)
        {
            Console.WriteLine("Введите значения для массива:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Элемент " + (i + 1) + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }
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
