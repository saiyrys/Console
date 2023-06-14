using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания от 1 до 3 для начала работы: ");

            int question = Convert.ToInt32(Console.ReadLine());

            switch (question)
            {
                case 1:
                    Console.Write("Введите любое 3-х значное число: ");

                    int tdigitТumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Вторая цифра вашего числа: {tdigitТumber / 10 % 10}");
                    break;
                case 2:
                    Console.WriteLine("Введите любое число для проверки 3 символа: ");

                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number / 100 % 10 == 0) {
                        Console.WriteLine("3 числа нет");
                    }
                    else { 
                        Console.WriteLine(number % 10);
                    }
                    break;
                case 3:
                    Console.Write("Введите число(день недели), что бы узнать выходной это или нет: ");

                    int weekend = Convert.ToInt32(Console.ReadLine());

                    if (weekend == 6 || weekend == 7)
                    {
                        Console.WriteLine($"{weekend} день недели является выходным!") ;
                    }
                    else
                    {
                        Console.WriteLine($"{weekend} день недели не выходной :( ");
                    }

                    break;
                default:
                    Console.WriteLine("Введено неккоректное число!");
                    break;
            }
        }
    }
}
