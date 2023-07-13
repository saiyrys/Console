using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlling_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите два неотрицательных числа m и n для вычисления функции Аккермана");
            Console.Write("Введите число m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine()); 

            int result = AckermannFunction(m, n);
            Console.WriteLine($"A({m}, {n}) = {result}");
        }

        static int AckermannFunction(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (n == 0)
                return AckermannFunction(m - 1, 1);
            else
                return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}
