using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

            SortRowsDescending(array);

            PrintArray(array);
        }

        static void SortRowsDescending(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] row = GetRow(array, i);
                Array.Sort(row, (a, b) => b.CompareTo(a));
                SetRow(array, i, row);
            }
        }

        static int[] GetRow(int[,] array, int rowIndex)
        {
            int rowLength = array.GetLength(1);
            int[] row = new int[rowLength];
            for (int j = 0; j < rowLength; j++)
            {
                row[j] = array[rowIndex, j];
            }
            return row;
        }

        static void SetRow(int[,] array, int rowIndex, int[] row)
        {
            int rowLength = array.GetLength(1);
            for (int j = 0; j < rowLength; j++)
            {
                array[rowIndex, j] = row[j];
            }
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

