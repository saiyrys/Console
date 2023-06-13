using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 1 до 4 для выбора задания: ");

            int task = Convert.ToInt32(Console.ReadLine());
            
            switch (task)
            {
                case 1:
                    Console.Write("Введите 1 число для сравнения: ");

                    int firstNumber = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите 2 число для сравнения: ");

                    int secondNumber = Convert.ToInt32(Console.ReadLine());

                    if (firstNumber > secondNumber) {
                        Console.WriteLine(firstNumber + " Больше чем " + secondNumber);
                    }
                    else if (firstNumber == secondNumber)
                    {
                        Console.WriteLine(firstNumber + " равно " + secondNumber);
                    }
                    else{
                        Console.WriteLine(secondNumber + " Больше чем " + firstNumber);
                    }
                    break;
                case 2:

                    Console.Write("Введите первое число: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите третье число: ");
                    int number3 = Convert.ToInt32(Console.ReadLine());

                    int maxNumber = Math.Max(number1, Math.Max(number2, number3));

                    Console.WriteLine("Максимальное число: " + maxNumber);

                    break;
                case 3:
                    Console.Write("Введите число для проверки его на четность: ");

                    int oddNumber = Convert.ToInt32(Console.ReadLine());

                    if (oddNumber % 2 == 0) {
                        Console.WriteLine(oddNumber + " Четное число! ");
                    }
                    else
                    {
                        Console.WriteLine(oddNumber + " Нечётное число! ");
                    }
                    break;
                case 4:

                    Console.WriteLine("Введите число N: ");
                    int N = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Четные числа от 1 до " + N + ":");

                    for (int i = 1; i <= N; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                    default:
                    Console.WriteLine("Вы ввели неккоректное число!");
                    break;
            }

        }
    }
}
