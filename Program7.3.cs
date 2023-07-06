using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

            int numColumns = matrix.GetLength(1);
            double[] columnAverages = GetColumnAverages(matrix, numColumns);

            Console.WriteLine("Среднее арифметическое каждого столбца:");

            for (int i = 0; i < numColumns; i++)
            {
                double roundedAverage = Math.Round(columnAverages[i], 1);
                Console.WriteLine("Столбец {0}: {1}", i + 1, roundedAverage);
            }
        }

        static double[] GetColumnAverages(int[,] matrix, int numColumns)
        {
            int numRows = matrix.GetLength(0);
            double[] columnAverages = new double[numColumns];

            for (int j = 0; j < numColumns; j++)
            {
                int sum = 0;

                for (int i = 0; i < numRows; i++)
                {
                    sum += matrix[i, j];
                }

                columnAverages[j] = (double)sum / numRows;
            }

            return columnAverages;
        }
    }
}

