using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = {
            { 1.2, 2.3, 3.4 },
            { 4.5, 5.6, 6.7 },
            { 7.8, 8.9, 9.0 }
        };

            Console.Write("Введите номер строки: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Введите номер столбца: ");
            int column = int.Parse(Console.ReadLine());

            double result = GetElementValue(matrix, row, column);

            if (result == double.MinValue)
            {
                Console.WriteLine("Такого элемента нет");
            }
            else
            {
                Console.WriteLine("Значение элемента: " + result);
            }
        }
        static double GetElementValue(double[,] matrix, int row, int column)
        {
            int numRows = matrix.GetLength(0);
            int numColumns = matrix.GetLength(1);

            if (row >= 1 && row <= numRows && column >= 1 && column <= numColumns)
            {
                return matrix[row - 1, column - 1];
            }
            else
            {
                return double.MinValue;
            }
        }
    }
}
