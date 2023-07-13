using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlling_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте значения M и N,что бы найти сумму натуральных элементов в промежутке от M до N.");

            Console.Write("Введите число М: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());

            int sum = CalculateSum(M, N);
            Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {sum}");
        }
        static int CalculateSum(int start, int end)
        {
            if (start > end)
                return 0;

            return start + CalculateSum(start + 1, end);
        }
    }
}
