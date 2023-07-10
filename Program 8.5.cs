using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];
            FillSpiralArray(array);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{array[i, j]:D2} ");
                }
                Console.WriteLine();
            }
        }

        static void FillSpiralArray(int[,] array)
        {
            int n = 4;
            int value = 1;

            int topRow = 0;
            int bottomRow = n - 1;
            int leftColumn = 0;
            int rightColumn = n - 1;

            while (value <= n * n)
            {

                for (int j = leftColumn; j <= rightColumn; j++)
                {
                    array[topRow, j] = value++;
                }
                topRow++;

                for (int i = topRow; i <= bottomRow; i++)
                {
                    array[i, rightColumn] = value++;
                }
                rightColumn--;

                for (int j = rightColumn; j >= leftColumn; j--)
                {
                    array[bottomRow, j] = value++;
                }
                bottomRow--;

                for (int i = bottomRow; i >= topRow; i--)
                {
                    array[i, leftColumn] = value++;
                }
                leftColumn++;
            }
        }
    }
}
