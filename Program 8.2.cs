using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

            int minSumRow = FindRowWithMinSum(array);

            Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1} строка");
        }

        static int FindRowWithMinSum(int[,] array)
        {
            int minSum = int.MaxValue;
            int minSumRow = -1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = GetRowSum(array, i);
                if (sum < minSum)
                {
                    minSum = sum;
                    minSumRow = i;
                }
            }

            return minSumRow;
        }

        static int GetRowSum(int[,] array, int rowIndex)
        {
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[rowIndex, j];
            }
            return rowSum;
        }
    }
}

