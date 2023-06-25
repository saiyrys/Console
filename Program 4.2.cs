using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_4._2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());

            int sum = CalculateDigitSum(number);

            Console.WriteLine("Сумма цифр числа: " + sum);

            Console.ReadLine();
        }
        static int CalculateDigitSum(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum;
        }
    }
}
