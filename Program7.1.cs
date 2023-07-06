using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 3;
            int n = 4;

            double[,] matrix = GenerateRandomMatrix(m, n);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static double[,] GenerateRandomMatrix(int rows, int columns)
        {
            Random rand = new Random();
            double[,] matrix = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rand.NextDouble();
                }
            }

            return matrix;
        }
    }
}
