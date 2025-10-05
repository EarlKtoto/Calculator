using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            char operation;
            int choice;
            bool isCompleted = false;

            try
            {
                do
                {
                    Console.Write("Введите 1-е число (допускается вещественного типа): ");
                    num1 = float.Parse(Console.ReadLine());

                    Console.Write("Введите 2-е число (допускается вещественного типа): ");
                    num2 = float.Parse(Console.ReadLine());

                    Console.Write("Введите арифметическую операцию операцию: ");
                    operation = char.Parse(Console.ReadLine());

                    switch (operation)
                    {
                        case '+':
                            Console.WriteLine($"Результат операции: {num1 + num2}");
                            break;
                        case '-':
                            Console.WriteLine($"Результат операции: {num1 - num2}");
                            break;
                        case '*':
                            Console.WriteLine($"Результат операции: {num1 * num2}");
                            break;
                        case '/':
                            if (num2 == 0) throw new DivideByZeroException();
                            Console.WriteLine($"Результат операции: {num1 / num2}");
                            break;
                        default:
                            throw new Exception("Нет такой арифметической операции!");
                            break;
                    }

                    Console.WriteLine("Желаете продолжить?\n" +
                                      "1) Да\n" +
                                      "2) Нет");

                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            isCompleted = false;
                            break;
                        case 2:
                            isCompleted = true;
                            break;
                        default:
                            throw new Exception("Нет такого варианта ответа!");
                            break;
                    }
                } while (!isCompleted);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: Неправильный тип!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: Делить на 0 нельзя!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
