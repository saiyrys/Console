using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи 1 или 2: ");

            int taskNumber = Convert.ToInt32(Console.ReadLine());

            bool isContinue = true;

            switch (taskNumber)
            {
                case 1:
                    while (isContinue)
                    {
                        Console.Write("Введите любое 5 - ти значное число, что бы узнать является ли оно палиндромом: ");

                        int polNumber = Convert.ToInt32(Console.ReadLine());

                        if (polNumber / 10000 == polNumber % 10 && polNumber / 1000 % 10 == polNumber % 100 / 10 && polNumber % 1000 / 100 == polNumber % 1000 / 100)
                        {
                            Console.WriteLine("Ваше число палиндром!");
                        }
                        else
                        {
                            Console.WriteLine("Ваше число не является палиндромом!");
                        }

                        Console.WriteLine("Хотите ли вы еще узнать?");

                        string question = Console.ReadLine();

                        if (question == "Нет" || question == "нет")
                        {
                            isContinue = false;
                        }
                    }
                    break;
                case 2:
                    while (isContinue)
                    {
                        Console.Write("Введите ваше число N: ");

                        int numberN = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= numberN; i++)
                        {
                            Console.WriteLine($"Кубы чисел от 1 до N: {i * i * i}");
                        }

                        Console.WriteLine("Хотите ли вы еще вычислить кубы?");

                        string question2 = Console.ReadLine();

                        if (question2 == "Нет" || question2 == "нет")
                        {
                            isContinue = false;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Неккоректное число!");
                    break;
            }

        }
    }
}
