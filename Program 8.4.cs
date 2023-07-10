using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = Create3DArray();

            Console.WriteLine("Трехмерный массив с индексами:");
            Print3DArray(array);
        }

        static int[,,] Create3DArray()
        {
            int[,,] array = new int[2, 2, 2];

            Random rand = new Random();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        array[i, j, k] = rand.Next(10, 100);
                    }
                }
            }

            return array;
        }

        static void Print3DArray(int[,,] array)
        {
            int size1 = array.GetLength(0);
            int size2 = array.GetLength(1);
            int size3 = array.GetLength(2);

            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    for (int k = 0; k < size3; k++)
                    {
                        Console.WriteLine($"{array[i, j, k]}({i},{j},{k})");
                    }
                }
            }
        }
    }
}
