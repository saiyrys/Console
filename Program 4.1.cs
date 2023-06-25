using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_4._1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B:");
            int B = int.Parse(Console.ReadLine());

            int result = CalculatePower(A, B); 

            Console.WriteLine("Результат: " + result);

            Console.ReadLine();
        }
        static int CalculatePower(int A, int B)
        {
            int result = 1;

            for (int i = 0; i < B; i++)
            {
                result *= A;
            }

            return result;
        }
    }
}
