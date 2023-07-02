using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько чисел вы хотите ввести: ");

            int M = int.Parse(Console.ReadLine());

            int[] valueNumbers = new int[M];

            for (int i = 0; i < M; i++)
            {
                Console.Write("Введите ваше число: ");
                valueNumbers[i] = int.Parse(Console.ReadLine());
            }

            int result = CountNumbers(valueNumbers);
            Console.WriteLine($"Чисел больше нуля: {result}");
        }
        static int CountNumbers (int[] numbers)
        {
            int count = 0;

            foreach(int num in numbers)
            {
                if (num > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
