using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод координат точек A и B
            Console.WriteLine("Введите координаты точки A:");
            Console.Write("X: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Z: ");
            double z1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты точки B:");
            Console.Write("X: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("Z: ");
            double z2 = double.Parse(Console.ReadLine());

            // Вычисление расстояния между точками
            double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);

            // Вывод результата
            Console.WriteLine("Расстояние между точками A и B: " + distance.ToString("0.00"));
        }
        static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double dz = z2 - z1;

            double distanceSquared = dx * dx + dy * dy + dz * dz;
            double distance = Math.Sqrt(distanceSquared);

            return distance;
        }
    }
}

