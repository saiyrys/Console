using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения b1, k1, b2 и k2:");

            double b1 = ReadDouble("b1");
            double k1 = ReadDouble("k1");
            double b2 = ReadDouble("b2");
            double k2 = ReadDouble("k2");

            double x = CalculateX(b1, k1, b2, k2);
            double y = CalculateY(k1, x, b1);

            Console.WriteLine($"Точка пересечения: ({x}; {y})");
        }

        static double ReadDouble(string variableName)
        {
            Console.Write($"{variableName} = ");
            return double.Parse(Console.ReadLine());
        }

        static double CalculateX(double b1, double k1, double b2, double k2)
        {
            return (b2 - b1) / (k1 - k2);
        }

        static double CalculateY(double k, double x, double b)
        {
            return k * x + b;
        }
    }
}

